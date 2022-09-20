using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using HospiEnCasa.App.Persistencia;
using HospiEnCasa.App.Dominio;

namespace HospiEnCasa.Frontend.Pages
{
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