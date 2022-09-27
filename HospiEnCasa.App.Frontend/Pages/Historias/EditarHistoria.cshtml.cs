using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using HospiEnCasa.App.Dominio;
using HospiEnCasa.App.Persistencia;

namespace HospiEnCasa.App.Frontend.Pages
{
    public class EditarHistoriaModel : PageModel
    {
        private static IRepositorioPaciente _repositorioPaciente = new RepositorioPaciente(new HospiEnCasa.App.Persistencia.AppContext());
        public IEnumerable<Paciente> Pacientes { get; set; }
        private static IRepositorioHistoria _repositorioHistoria = new RepositorioHistoria(new HospiEnCasa.App.Persistencia.AppContext());

        [BindProperty]
        public Historia Historia{get; set; }
        
        public ActionResult OnGet(int id)
        {
            this.Pacientes = _repositorioPaciente.GetAllPacientes();
            this.Historia = _repositorioHistoria.GetHistoria(id);
            return Page();
        }
        public ActionResult OnPost()
        {
            try{
                Historia HistoriaActualizado = _repositorioHistoria.UpdateHistoria(Historia);
                return RedirectToPage("./ListaHistorias");
            } 
            catch(System.Exception e)
            {
                ViewData["Error"] = "Error: " + e.Message;
                return Page();
            }
        }
    }
}
