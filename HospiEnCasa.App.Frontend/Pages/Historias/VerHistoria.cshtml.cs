using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using HospiEnCasa.App.Dominio;
using HospiEnCasa.App.Persistencia;

namespace HospiEnCasa.App.Frontend.Pages
{
    public class VerHistoriaModel : PageModel
    {
        private static IRepositorioHistoria _repositorioHistoria = new RepositorioHistoria(new HospiEnCasa.App.Persistencia.AppContext());
        [BindProperty]
        public Historia Historia{get; set; }
        public VerHistoriaModel()
        {}
        public ActionResult OnGet(int id)
        {
            this.Historia = _repositorioHistoria.GetHistoria(id);
            return Page();
        }
    }
}
