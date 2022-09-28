using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using HospiEnCasa.App.Dominio;
using HospiEnCasa.App.Persistencia;

namespace HospiEnCasa.App.Frontend.Pages
{
    public class EliminarHistoriaModel : PageModel
    {
        private static IRepositorioHistoria _repositorioHistoria = new RepositorioHistoria(new HospiEnCasa.App.Persistencia.AppContext());

        [BindProperty]
        public Historia Historia{get; set; }
        public ActionResult OnGet(int id)
        {
             try{
                _repositorioHistoria.DeleteHistoria(id);
                return RedirectToPage("./ListaHistorias");
            } catch(System.Exception e)
            {
                ViewData["Error"] = "Error: " + e.Message;
            }
            return Page();
        }
    }
}
