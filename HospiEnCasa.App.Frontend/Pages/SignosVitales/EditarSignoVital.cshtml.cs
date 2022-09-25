using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using HospiEnCasa.App.Dominio;
using HospiEnCasa.App.Persistencia;

namespace HospiEnCasa.Frontend.Pages
{
    public class EditarSignoVitalModel : PageModel
    {
        private static IRepositorioSignoVital _repositorioSignoVital = new RepositorioSignoVital(new HospiEnCasa.App.Persistencia.AppContext());
        private static IRepositorioPaciente _repositorioPaciente = new RepositorioPaciente(new HospiEnCasa.App.Persistencia.AppContext());
        
        public IEnumerable<Paciente> Pacientes {get; set;}
        
        [BindProperty]
        public SignoVital signoVital { get; set; }

        public ActionResult OnGet(int id)
        {
            this.signoVital= _repositorioSignoVital.GetSignoVital(id);
             this.Pacientes = _repositorioPaciente.GetAllPacientes();
            return Page();
        }
        public ActionResult OnPost()
        {
            try
            {
                SignoVital signoVitalActualizado= _repositorioSignoVital.UpdateSignoVital(signoVital);
                return RedirectToPage("./ListadoSignosVitales");
            }
            catch (System.Exception e)
            {
                ViewData["Error"] = "Error: " + e.Message;
                return Page();
            }
        }
    }
}