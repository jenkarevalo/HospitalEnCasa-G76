using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using HospiEnCasa.App.Dominio;
using HospiEnCasa.App.Persistencia;

namespace HospiEnCasa.App.Frontend.Pages
{
    public class VerSugerenciaCuidadoModel : PageModel
    {
        private static IRepositorioSugerenciaCuidado _repositorioSugerenciaCuidado = new RepositorioSugerenciaCuidado(new HospiEnCasa.App.Persistencia.AppContext());
        //Generar una variable para mapear que llega del signo desde la Bds
        [BindProperty]
        public SugerenciaCuidado SugerenciaCuidado {get; set;}
        //Constructor
        public VerSugerenciaCuidadoModel()
        {}
        public ActionResult OnGet(int id)
        {
            this.SugerenciaCuidado = _repositorioSugerenciaCuidado.GetSugerenciaCuidadoAndPaciente(id); 
            return Page();
        }
    }
}
