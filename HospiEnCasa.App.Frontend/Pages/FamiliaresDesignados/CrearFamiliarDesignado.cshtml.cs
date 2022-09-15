using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using HospiEnCasa.App.Dominio;
using HospiEnCasa.App.Persistencia;

namespace HospiEnCasa.Frontend.Pages
{
    public class CrearFamiliarDesignadoModel : PageModel
    {
        private static IRepositorioFamiliarDesignado _repositorioFamiliarDesignado = new RepositorioFamiliarDesignado(new HospiEnCasa.App.Persistencia.AppContext());

        public FamiliarDesignado FamiliarDesignado { get; set; }

        public CrearFamiliarDesignadoModel()
        { }


        public ActionResult OnGet()
        {
            return Page();
        }

        public ActionResult OnPost()
        {
            try
            {
                FamiliarDesignado familiarAdicionado = _repositorioFamiliarDesignado.AddFamiliarDesignado(FamiliarDesignado);
                return RedirectToPage("./ListaFamiliarDesignado");
            }
            catch (System.Exception e)
            {
                ViewData["Error"] = "Error: " + e.Message;
                return Page();
            }
        }

    }
}
