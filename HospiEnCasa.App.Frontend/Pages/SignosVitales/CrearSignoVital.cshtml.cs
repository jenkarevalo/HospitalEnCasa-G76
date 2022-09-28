using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using HospiEnCasa.App.Dominio;
using HospiEnCasa.App.Persistencia;
using Microsoft.AspNetCore.Authorization;


namespace HospiEnCasa.Frontend.Pages
{   [Authorize]
    public class CrearSignoVitalModel : PageModel
    {
        //Conexion a la Bds
        private static IRepositorioSignoVital _repositorioSignoVital= new RepositorioSignoVital(new HospiEnCasa.App.Persistencia.AppContext());
        private static IRepositorioPaciente _repositorioPaciente = new RepositorioPaciente(new HospiEnCasa.App.Persistencia.AppContext());

        public IEnumerable<Paciente> Pacientes {get; set;}

        [BindProperty]
        public SignoVital SignoVital{get; set;} 

        //consultar listado pacientes Bds
        public CrearSignoVitalModel()
        {}
        
        public ActionResult OnGet()
        {
            this.Pacientes = _repositorioPaciente.GetAllPacientes();
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
