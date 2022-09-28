using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using HospiEnCasa.App.Dominio;
using HospiEnCasa.App.Persistencia;
using Microsoft.AspNetCore.Authorization;

namespace HospiEnCasa.App.Frontend.Pages
{   [Authorize]
    public class CrearEnfermeraModel : PageModel
    {
        private static IRepositorioEnfermera _repositorioEnfermera = new RepositorioEnfermera(new HospiEnCasa.App.Persistencia.AppContext());

        [BindProperty]
        public Enfermera Enfermera{get; set; }
        public CrearEnfermeraModel()
        {}
        public ActionResult OnGet()
        {
            return Page();
        }
        public ActionResult OnPost()
        {
            try{
                Enfermera enfermeraAdicionado = _repositorioEnfermera.AddEnfermera(Enfermera);
                return RedirectToPage("./ListadoEnfermeras");
            } catch(System.Exception e)
            {
                ViewData["Error"] = "Error: " + e.Message;
                return Page();
            }
        }
    }
}
