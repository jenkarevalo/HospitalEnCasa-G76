using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using HospiEnCasa.App.Dominio;
using HospiEnCasa.App.Persistencia;

namespace HospiEnCasa.Frontend.Pages
{
    public class EditarFamiliarDesignadoModel : PageModel
    {private static IRepositorioFamiliarDesignado _repositorioFamiliarDesignado = new RepositorioFamiliarDesignado(new HospiEnCasa.App.Persistencia.AppContext());
        [BindProperty]
         public FamiliarDesignado FamiliarDesignado { get; set; }

        public EditarFamiliarDesignadoModel()
        { }


        public ActionResult OnGet(int id)
        {
            this.FamiliarDesignado= _repositorioFamiliarDesignado.GetFamiliarDesignado(id);
            return Page();
        }

        public ActionResult OnPost()
        {
            try
            {
                FamiliarDesignado familiarActualizado = _repositorioFamiliarDesignado.UpdateFamiliarDesignado(FamiliarDesignado);
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
