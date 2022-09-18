using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using HospiEnCasa.App.Dominio;
using HospiEnCasa.App.Persistencia;

namespace HospiEnCasa.Frontend.Pages
{
    public class CrearSignoVitalModel : PageModel
    {
        //Conexion a la Bds
        private static IRepositorioSignoVital _repositorioSignoVital= new RepositorioSignoVital(new HospiEnCasa.App.Persistencia.AppContext());
        [BindProperty]
        public SignoVital SignoVital{get; set;} 
        public CrearSignoVitalModel()
        {}
        public ActionResult OnGet()
        {
            return Page();
        }
        public ActionResult OnPost()
        {   
            try{
                SignoVital.FechaHora = System.DateTime.Now;
                
                SignoVital signoVitalAdicionado =_repositorioSignoVital.AddSignoVital(SignoVital);
                return RedirectToPage("./ListadoSignosVitales");
            }catch (System.Exception e)
            {
                ViewData["Error"] = "Error: " + e.Message;
                return Page();
            }    

        }
    }
}
