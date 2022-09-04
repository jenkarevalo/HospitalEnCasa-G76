namespace HospiEnCasa.App.Dominio
{
    public class FamiliarDesignado:Persona
    {
       public int Id {get; set;}
       public string Parentesco {get; set;} 
       public string Correo { get; set;}
       public int PacienteId {get; set;}
    }
}