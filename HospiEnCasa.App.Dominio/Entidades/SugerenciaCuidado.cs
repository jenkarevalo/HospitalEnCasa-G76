namespace HospiEnCasa.App.Dominio
{
    public class SugerenciaCuidado
    {
       public int Id {get; set;}
       public DateTime FechaHora {get; set;}
       public string Descripcion {get; set;}
       public int HistoriaId {get; set;}
       public Historia Historia {get; set;} 


    }

}