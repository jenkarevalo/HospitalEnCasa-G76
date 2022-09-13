using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using HospiEnCasa.App.Dominio;
using HospiEnCasa.App.Persistencia;

namespace HospiEnCasa.Frontend.Pages
{
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
