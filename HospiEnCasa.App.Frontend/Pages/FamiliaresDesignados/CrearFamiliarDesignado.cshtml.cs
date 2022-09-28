using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using HospiEnCasa.App.Dominio;
using HospiEnCasa.App.Persistencia;
using Microsoft.AspNetCore.Authorization;

namespace HospiEnCasa.Frontend.Pages
{   [Authorize]
    public class CrearFamiliarDesignadoModel : PageModel
    {   
        private static IRepositorioPaciente _repositorioPaciente = new RepositorioPaciente(new HospiEnCasa.App.Persistencia.AppContext());
        [BindProperty]
        public IEnumerable<Paciente> Pacientes { get; set; }
        private static IRepositorioFamiliarDesignado _repositorioFamiliarDesignado = new RepositorioFamiliarDesignado(new HospiEnCasa.App.Persistencia.AppContext());
         [BindProperty]
        public FamiliarDesignado FamiliarDesignado { get; set; }

        public CrearFamiliarDesignadoModel()
        { }


        public ActionResult OnGet(int id)
        {   this.Pacientes = _repositorioPaciente.GetAllPacientes();
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
