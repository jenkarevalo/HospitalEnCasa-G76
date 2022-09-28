using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using HospiEnCasa.App.Dominio;
using HospiEnCasa.App.Persistencia;

namespace HospiEnCasa.App.Frontend.Pages
{
    public class CrearSugerenciaCuidadosModel : PageModel
    {
        private static IRepositorioSugerenciaCuidado _repositorioSugerenciaCuidado= new RepositorioSugerenciaCuidado(new HospiEnCasa.App.Persistencia.AppContext());
        private static IRepositorioHistoria _repositorioHistoria = new RepositorioHistoria(new HospiEnCasa.App.Persistencia.AppContext());
        
        public IEnumerable<Historia> Historias {get; set;}

        [BindProperty]
        public SugerenciaCuidado SugerenciaCuidado{get; set;} 

        //consultar listado pacientes Bds
        public CrearSugerenciaCuidadosModel()
        {}
        
        public ActionResult OnGet()
        {
            this.Historias = _repositorioHistoria.GetAllHistorias();
            return Page();
        }
        public ActionResult OnPost()
        {   
            try{
                SugerenciaCuidado.FechaHora = System.DateTime.Now;
                
                SugerenciaCuidado SugerenciaCuidadoAdicionado =_repositorioSugerenciaCuidado.AddSugerenciaCuidado(SugerenciaCuidado);
                return RedirectToPage("./ListaSugerenciaCuidados");
            }catch (System.Exception e)
            {
                ViewData["Error"] = "Error: " + e.Message;
                return Page();
            }    

        }
    }
}
