using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using HospiEnCasa.App.Dominio;
using HospiEnCasa.App.Persistencia;
using Microsoft.AspNetCore.Authorization;

namespace HospiEnCasa.Frontend.Pages
{    [Authorize]
    public class EliminarSignoVitalModel : PageModel
    {
        private static IRepositorioSignoVital _repositorioSignoVital = new RepositorioSignoVital(new HospiEnCasa.App.Persistencia.AppContext());
        [BindProperty]
        public SignoVital SignoVital { get; set; }

        public ActionResult OnGet(int id)
        {
            try
            {
                _repositorioSignoVital.DeleteSignoVital(id);
                return RedirectToPage("./ListadoSignosVitales");
            } catch(System.Exception e)
            {
                ViewData["Error"] = "Error: " + e.Message;
            }
            return Page();
        }
    }
}
