using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using HospiEnCasa.App.Dominio;
using HospiEnCasa.App.Persistencia;

namespace HospiEnCasa.App.Frontend.Pages
{
    public class LoginModel : PageModel
    {
         private static IRepositorioUsuario _repositorioUsuario = new RepositorioUsuario(new HospiEnCasa.App.Persistencia.AppContext());
        [BindProperty]

        public Usuario Usuario {get; set;}

        public LoginModel()
        {}

        public void OnGet()
        {
            
        }

        public void onPost()
        {
            Console.WriteLine("TEST");
            Console.WriteLine(Usuario.User);
            Console.WriteLine(Usuario.Password);
        }
    }

}
