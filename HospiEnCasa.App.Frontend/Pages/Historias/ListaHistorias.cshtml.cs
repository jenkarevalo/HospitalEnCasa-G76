using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using HospiEnCasa.App.Dominio;
using HospiEnCasa.App.Persistencia;

namespace HospiEnCasa.App.Frontend.Pages
{
    public class ListaHistoriasModel : PageModel
    {
        private static IRepositorioHistoria _repositorioHistoria = new RepositorioHistoria(new HospiEnCasa.App.Persistencia.AppContext());
        
        //Declaro una variable para la lista
        public IEnumerable<Historia> Historias{get; set; }
        
        //Realizamos el constructor
        public ListaHistoriasModel()
        {}
        public void OnGet()
        {
            this.Historias = _repositorioHistoria.GetAllHistorias();
        }
    }
}
