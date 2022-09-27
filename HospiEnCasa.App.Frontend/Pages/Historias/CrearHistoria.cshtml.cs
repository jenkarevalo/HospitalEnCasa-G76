using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using HospiEnCasa.App.Dominio;
using HospiEnCasa.App.Persistencia;

namespace HospiEnCasa.App.Frontend.Pages
{
    public class CrearHistoriaModel : PageModel
    {
        private static IRepositorioPaciente _repositorioPaciente = new RepositorioPaciente(new HospiEnCasa.App.Persistencia.AppContext());
        [BindProperty]
        public Paciente Paciente{get; set; }

        [BindProperty]
        public IEnumerable<Paciente> Pacientes { get; set; }
        private static IRepositorioHistoria _repositorioHistoria = new RepositorioHistoria(new HospiEnCasa.App.Persistencia.AppContext());

        [BindProperty]
        public Historia Historia{get; set; }
        public CrearHistoriaModel()
        {}

        public ActionResult OnGet()
        {
            this.Pacientes = _repositorioPaciente.GetAllPacientes();
            return Page();
        }
        public ActionResult OnPost()
        {
            try{
                Historia historiaAdicionado = _repositorioHistoria.AddHistoria(Historia);
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
