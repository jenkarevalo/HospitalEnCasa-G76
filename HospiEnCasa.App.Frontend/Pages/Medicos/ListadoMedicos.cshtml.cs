using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using HospiEnCasa.App.Dominio;
using HospiEnCasa.App.Persistencia;

namespace HospiEnCasa.App.Frontend.Pages
{
    public class ListadoMedicosModel : PageModel
    {
        // Conexión a la Base de Datos
        private static IRepositorioMedico _repositorioMedico = new RepositorioMedico(new HospiEnCasa.App.Persistencia.AppContext());
        
        //Declaro una variable para la lista
        public IEnumerable<Medico> Medicos{get; set; }
        
        //Realizamos el constructor
        public ListadoMedicosModel()
        {}
        public void OnGet()
        {
            this.Medicos = _repositorioMedico.GetAllMedicos();
        }
    }
}
