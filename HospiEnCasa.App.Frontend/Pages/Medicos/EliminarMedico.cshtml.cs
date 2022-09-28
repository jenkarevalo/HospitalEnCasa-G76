using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using HospiEnCasa.App.Dominio;
using HospiEnCasa.App.Persistencia;
using Microsoft.AspNetCore.Authorization;

namespace HospiEnCasa.App.Frontend.Pages
{   [Authorize]
    public class EliminarMedicoModel : PageModel
    {
        private static IRepositorioMedico _repositorioMedico = new RepositorioMedico(new HospiEnCasa.App.Persistencia.AppContext());

        [BindProperty]
        public Medico Medico{get; set; }
        
        public ActionResult OnGet(int id)
        {
             try{
                _repositorioMedico.DeleteMedico(id);
                return RedirectToPage("./ListadoMedicos");
            } catch(System.Exception e)
            {
                ViewData["Error"] = "Error: " + e.Message;
            }
            return Page();
        }
    }
}
