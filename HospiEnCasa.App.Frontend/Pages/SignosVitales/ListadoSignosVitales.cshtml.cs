using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using HospiEnCasa.App.Dominio;
using HospiEnCasa.App.Persistencia;

namespace HospiEnCasa.Frontend.Pages
{
    public class ListadoSignosVitalesModel : PageModel
    {
        //Conexion a la Bds
        private static IRepositorioSignoVital _repositorioSignoVital= new RepositorioSignoVital(new HospiEnCasa.App.Persistencia.AppContext());

        //Declaro una variable para la lista de Usuarios 
        public IEnumerable<SignoVital> SignoVital{get; set;}

        //Constructor
        public ListadoSignosVitalesModel()
        {}
        public void OnGet()
        {
            this.SignoVital = _repositorioSignoVital.GetAllSignosVitales();
        }
    }
}
