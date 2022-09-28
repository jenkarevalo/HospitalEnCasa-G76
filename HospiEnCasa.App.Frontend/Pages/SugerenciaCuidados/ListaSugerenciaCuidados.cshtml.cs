using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using HospiEnCasa.App.Dominio;
using HospiEnCasa.App.Persistencia;

namespace HospiEnCasa.App.Frontend.Pages
{
    public class ListaSugerenciaCuidadosModel : PageModel
    {
        private static IRepositorioSugerenciaCuidado _repositorioSugerenciaCuidado= new RepositorioSugerenciaCuidado(new HospiEnCasa.App.Persistencia.AppContext());

        //Declaro una variable para la lista de Usuarios 
        public IEnumerable<SugerenciaCuidado> SugerenciaCuidado{get; set;}

        //Constructor
        public ListaSugerenciaCuidadosModel()
        {}
        public void OnGet()
        {
            this.SugerenciaCuidado = _repositorioSugerenciaCuidado.GetAllSugerenciaCuidadosAndPacientes();
        }
    }
}
