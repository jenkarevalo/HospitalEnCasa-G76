using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using HospiEnCasa.App.Dominio;
using HospiEnCasa.App.Persistencia;

namespace HospiEnCasa.App.Frontend.Pages
{
    public class EliminarSugerenciaCuidadoModel : PageModel
    {
        private static IRepositorioSugerenciaCuidado _repositorioSugerenciaCuidado = new RepositorioSugerenciaCuidado(new HospiEnCasa.App.Persistencia.AppContext());
        [BindProperty]
        public SugerenciaCuidado SugerenciaCuidado { get; set; }

        public ActionResult OnGet(int id)
        {
            try
            {
                _repositorioSugerenciaCuidado.DeleteSugerenciaCuidado(id);
                return RedirectToPage("./ListaSugerenciaCuidados");
            } catch(System.Exception e)
            {
                ViewData["Error"] = "Error: " + e.Message;
            }
            return Page();
        }
    }
}
