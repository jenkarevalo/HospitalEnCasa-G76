using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using HospiEnCasa.App.Dominio;
using HospiEnCasa.App.Persistencia;
using Microsoft.AspNetCore.Authorization;

namespace HospiEnCasa.Frontend.Pages
{
     [Authorize]
    public class ListaPacientesModel : PageModel
    {
        private static IRepositorioMedico _repositorioMedico = new RepositorioMedico(new HospiEnCasa.App.Persistencia.AppContext());
        private static IRepositorioPaciente _repositorioPaciente = new RepositorioPaciente(new HospiEnCasa.App.Persistencia.AppContext());
        
        //[BindProperty]
        public Medico Medico {get; set; }
        public IEnumerable<Paciente> Pacientes { get; set; }

        public ListaPacientesModel()
        {}

        public void OnGet()
        {
            Pacientes = _repositorioPaciente.GetAllPacientes(); 
        }

        public void OnGetMedico(int? idMedico)
        {
            if (idMedico.HasValue){
                this.Medico = _repositorioMedico.GetMedico(idMedico.Value);
                this.Medico = _repositorioMedico.GetMedicoWithPacientes(idMedico.Value);
            }else {
                Pacientes = _repositorioPaciente.GetAllPacientes();
            }   
        }
    }
}
