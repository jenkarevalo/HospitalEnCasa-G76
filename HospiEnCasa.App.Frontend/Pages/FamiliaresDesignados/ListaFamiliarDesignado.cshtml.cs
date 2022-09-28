using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using HospiEnCasa.App.Dominio;
using HospiEnCasa.App.Persistencia;
using Microsoft.AspNetCore.Authorization;

namespace HospiEnCasa.Frontend.Pages
{   [Authorize]
    public class ListaFamiliarDesignadoModel : PageModel
    { private static IRepositorioFamiliarDesignado _repositorioFamiliarDesignado= new RepositorioFamiliarDesignado(new HospiEnCasa.App.Persistencia.AppContext());

        public IEnumerable<FamiliarDesignado> FamiliarDesignado {get; set;}

        public ListaFamiliarDesignadoModel()
        {}


        public void OnGet()
        {
            this.FamiliarDesignado= _repositorioFamiliarDesignado.GetAllFamiliar();
        }
    }
}
