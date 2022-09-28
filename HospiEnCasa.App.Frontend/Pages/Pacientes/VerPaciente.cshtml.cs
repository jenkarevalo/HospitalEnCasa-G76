using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using HospiEnCasa.App.Persistencia;
using HospiEnCasa.App.Dominio;
using Microsoft.AspNetCore.Authorization;


namespace HospiEnCasa.Frontend.Pages
{   [Authorize]
    public class VerPacienteModel : PageModel
    {
        private static IRepositorioPaciente _repositorioPaciente = new RepositorioPaciente(new HospiEnCasa.App.Persistencia.AppContext());

        [BindProperty]
        public Paciente Paciente { get; set; }

        public VerPacienteModel()
        { }

        public ActionResult OnGet(int id)
        {
            this.Paciente= _repositorioPaciente.GetPaciente(id);
            return Page();
        }
    }
}