using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using HospiEnCasa.App.Dominio;
using HospiEnCasa.App.Persistencia;

namespace HospiEnCasa.App.Frontend.Pages
{
    public class EditarEnfermeraModel : PageModel
    {
        private static IRepositorioEnfermera _repositorioEnfermera = new RepositorioEnfermera(new HospiEnCasa.App.Persistencia.AppContext());

        [BindProperty]
        public Enfermera Enfermera{get; set; }
        
        public ActionResult OnGet(int id)
        {
            this.Enfermera = _repositorioEnfermera.GetEnfermera(id);
            return Page();
        }
        public ActionResult OnPost()
        {
            try{
                Enfermera enfermeraActualizado = _repositorioEnfermera.UpdateEnfermera(Enfermera);
                return RedirectToPage("./ListadoEnfermeras");
            } catch(System.Exception e)
            {
                ViewData["Error"] = "Error: " + e.Message;
                return Page();
            }
        }
    }
}
