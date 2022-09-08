using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using HospiEnCasa.App.Dominio;
using HospiEnCasa.App.Persistencia;

namespace HospiEnCasa.App.Frontend.Pages
{
    public class EliminarEnfermeraModel : PageModel
    {
        private static IRepositorioEnfermera _repositorioEnfermera = new RepositorioEnfermera(new HospiEnCasa.App.Persistencia.AppContext());

        [BindProperty]
        public Enfermera Enfermera{get; set; }
        
        public ActionResult OnGet(int id)
        {
             try{
                _repositorioEnfermera.DeleteEnfermera(id);
                return RedirectToPage("./ListadoEnfermeras");
            } catch(System.Exception e)
            {
                ViewData["Error"] = "Error: " + e.Message;
            }
            return Page();
        }
    }
}
