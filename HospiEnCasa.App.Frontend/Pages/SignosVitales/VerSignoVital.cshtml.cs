using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using HospiEnCasa.App.Persistencia;
using HospiEnCasa.App.Dominio;

namespace HospiEnCasa.Frontend.Pages
{
    public class VerSignoVitalModel : PageModel
    {
        // Conectarse a la Bd
        private static IRepositorioSignoVital _repositorioSignoVital = new RepositorioSignoVital(new HospiEnCasa.App.Persistencia.AppContext());
        //Generar una variable para mapear que llega del signo desde la Bds
        [BindProperty]
        public SignoVital SignoVital {get; set;}
        //Constructor
        public VerSignoVitalModel()
        {}
        public ActionResult OnGet(int id)
        {
            this.SignoVital = _repositorioSignoVital.GetSignoVitalAndPaciente(id); 
            return Page();
        }
    }
}