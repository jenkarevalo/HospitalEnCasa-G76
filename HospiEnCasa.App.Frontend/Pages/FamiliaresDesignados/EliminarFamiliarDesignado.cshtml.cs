using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using HospiEnCasa.App.Dominio;
using HospiEnCasa.App.Persistencia;

namespace HospiEnCasa.Frontend.Pages
{
    public class EliminarFamiliarDesignadoModel : PageModel
    {private static IRepositorioFamiliarDesignado _repositorioFamiliarDesignado= new RepositorioFamiliarDesignado(new HospiEnCasa.App.Persistencia.AppContext());
        
     [BindProperty]   

     public FamiliarDesignado FamiliarDesignado{get; set;}
        


        public ActionResult OnGet(int id)
        {
            try{
                _repositorioFamiliarDesignado.DeleteFamiliarDesignado(id);
                return RedirectToPage("./ListaFamiliarDesignado");
            }catch (System.Exception e)
            {
                ViewData["Error"]= "Error: "+ e.Message;
            }
            return Page();
        }   
    }
}
