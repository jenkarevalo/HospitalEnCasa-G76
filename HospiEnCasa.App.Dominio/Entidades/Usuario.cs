namespace HospiEnCasa.App.Dominio
{
    public class Usuario
    {
       public int Id {get; set;}
       public string User {get; set;} 
       public string Password {get; set;}

       public Rol IdRol {get; set;}
       
    }
}