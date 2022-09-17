namespace HospiEnCasa.App.Dominio
{
    public class SignoVital
    {
       public int Id {get; set;}
       public DateTime FechaHora {get; set;}
       public string Signo {get; set;}
       public float Valor {get; set;}
       public int PacienteId {get; set;} 
       public Paciente Paciente{get; set;}
  

    }

}