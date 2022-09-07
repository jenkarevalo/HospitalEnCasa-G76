using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using HospiEnCasa.App.Dominio;
using HospiEnCasa.App.Persistencia;

namespace HospiEnCasa.App.Frontend.Pages
{
    public class EditarMedicoModel : PageModel
    {
        private static IRepositorioMedico _repositorioMedico = new RepositorioMedico(new HospiEnCasa.App.Persistencia.AppContext());

        [BindProperty]
        public Medico Medico{get; set; }
        
        public ActionResult OnGet(int id)
        {
            this.Medico = _repositorioMedico.GetMedico(id);
            return Page();
        }
        public ActionResult OnPost()
        {
            try{
                Medico medicoActualizado = _repositorioMedico.UpdateMedico(Medico);
                return RedirectToPage("./ListadoMedicos");
            } catch(System.Exception e)
            {
                ViewData["Error"] = "Error: " + e.Message;
                return Page();
            }
        }
    }
}
