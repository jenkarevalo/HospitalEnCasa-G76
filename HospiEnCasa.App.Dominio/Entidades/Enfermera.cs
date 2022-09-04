namespace HospiEnCasa.App.Dominio
{
    public class Enfermera:Persona
    {
       public int Id {get; set;}
       public string TarjetaProfesional {get; set;} 
       public int HorasLaborales {get; set;}
       public List<Paciente> ListaPacientes {get; set;}

    }



}