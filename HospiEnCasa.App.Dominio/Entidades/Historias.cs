namespace HospiEnCasa.App.Dominio
{
    public class Historia
    {
       public int Id {get; set;}
       public string Diagnostico {get; set;}
       public string Entorno {get; set;}
       public int PacienteId {get; set;}
       public List<SugerenciaCuidado> ListaSugerenciaCuidado {get; set;}

  

    }

}