using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using HospiEnCasa.App.Dominio;
using HospiEnCasa.App.Persistencia;

namespace HospiEnCasa.Frontend.Pages
{
    public class EditarPacienteModel : PageModel
    {
        private static IRepositorioMedico _repositorioMedico = new RepositorioMedico(new HospiEnCasa.App.Persistencia.AppContext());
        public IEnumerable<Medico> Medicos { get; set; }
        private static IRepositorioPaciente _repositorioPaciente = new RepositorioPaciente(new HospiEnCasa.App.Persistencia.AppContext());

        [BindProperty]
        public Paciente Paciente { get; set; }

        public EditarPacienteModel()
        { }

        public ActionResult OnGet(int id)
        {
            this.Medicos = _repositorioMedico.GetAllMedicos();
            this.Paciente= _repositorioPaciente.GetPaciente(id);
            return Page();
        }

        public ActionResult OnPost()
        {
            try
            {
                Paciente pacienteActualizado = _repositorioPaciente.UpdatePaciente(Paciente);
                return Redirect("./ListaPacientes");
            }
            catch (System.Exception e)
            {
                ViewData["Error"] = "Error: " + e.Message;
                return Page();
            }
        }
    }
}
