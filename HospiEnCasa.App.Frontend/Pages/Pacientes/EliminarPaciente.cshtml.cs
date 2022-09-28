using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using HospiEnCasa.App.Dominio;
using HospiEnCasa.App.Persistencia;
using Microsoft.AspNetCore.Authorization;

namespace HospiEnCasa.Frontend.Pages
{   [Authorize]
    public class EliminarPacienteModel : PageModel
    {
        private static IRepositorioPaciente _repositorioPaciente = new RepositorioPaciente(new HospiEnCasa.App.Persistencia.AppContext());
        [BindProperty]
        public Paciente Paciente { get; set; }

        public ActionResult OnGet(int id)
        {
            try
            {
                _repositorioPaciente.DeletePaciente(id);
                return RedirectToPage("./ListaPacientes");
            }
            catch (System.Exception e)
            {
                ViewData["Error"] = "Error: " + e.Message;
            }
            return Page();
        }
    }
}
