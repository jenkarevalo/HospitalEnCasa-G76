using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using HospiEnCasa.App.Dominio;
using HospiEnCasa.App.Persistencia;

namespace HospiEnCasa.App.Frontend.Pages
{
    public class ListadoEnfermerasModel : PageModel
    {
        // Conexión a la Base de Datos
        private static IRepositorioEnfermera _repositorioEnfermera = new RepositorioEnfermera(new HospiEnCasa.App.Persistencia.AppContext());
        
        //Declaro una variable para la lista
        public IEnumerable<Enfermera> Enfermeras{get; set; }
        
        //Realizamos el constructor
        public ListadoEnfermerasModel()
        {}
        public void OnGet()
        {
            this.Enfermeras = _repositorioEnfermera.GetAllEnfermeras();
        }
    }
}