namespace HospiEnCasa.App.Dominio
{
    public class Medico:Persona
    {
       public int Id {get; set;}
       public string Codigo {get; set;}
       public string Especialidad {get; set;}
       public List<Paciente> ListaPacientes {get; set;}
    }
}