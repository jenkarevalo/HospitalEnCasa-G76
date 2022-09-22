using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using HospiEnCasa.App.Dominio;
using HospiEnCasa.App.Persistencia;

namespace HospiEnCasa.Frontend.Pages
{
    public class CrearPacientesModel : PageModel
    { 
        private static IRepositorioMedico _repositorioMedico = new RepositorioMedico(new HospiEnCasa.App.Persistencia.AppContext());

        private static IRepositorioEnfermera _repositorioEnfermera = new RepositorioEnfermera(new HospiEnCasa.App.Persistencia.AppContext());

        public IEnumerable<Enfermera> Enfermeras { get; set; }
        public IEnumerable<Medico> Medicos { get; set; }
        private static IRepositorioPaciente _repositorioPaciente = new RepositorioPaciente(new HospiEnCasa.App.Persistencia.AppContext());
        [BindProperty]
        public Paciente Paciente { get; set; }

        public CrearPacientesModel()
        { }



        public ActionResult OnGet()
        {
            this.Medicos = _repositorioMedico.GetAllMedicos();
            this.Enfermeras = _repositorioEnfermera.GetAllEnfermeras();
            return Page();
        }

        public ActionResult OnPost()
        {
            try
            {
                Paciente pacienteAdicionado = _repositorioPaciente.AddPaciente(Paciente);
                return Redirect("./ListaPacientes");
                //return new Page();
            }
            catch (System.Exception e)
            {
                ViewData["Error"] = "Error: " + e.Message;
                return Page();
            }
        }
    }      
}

