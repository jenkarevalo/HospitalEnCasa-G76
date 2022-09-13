using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using HospiEnCasa.App.Dominio;
using HospiEnCasa.App.Persistencia;

namespace HospiEnCasa.Frontend.Pages
{
    public class VerFamiliarDesignadoModel : PageModel
    { private static IRepositorioFamiliarDesignado _repositorioFamiliarDesignado = new RepositorioFamiliarDesignado(new HospiEnCasa.App.Persistencia.AppContext());
    
    public FamiliarDesignado FamiliarDesignado {get; set;}

    public VerFamiliarDesignadoModel()
    {}

        public ActionResult OnGet(int id)
        {
            this.FamiliarDesignado= _repositorioFamiliarDesignado.GetFamiliarDesignado(id);
            return Page();
        }
    }
}
