using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HospiEnCasa.App.Dominio
{
    public class SugerenciaCuidado
    {
       public int Id {get; set;}
       [Required(ErrorMessage="El campo Fecha y Hora es obligatorio")]
       public DateTime FechaHora {get; set;}
       [Required(ErrorMessage="El campo Descripcion es obligatorio")]
       public string Descripcion {get; set;}
       public int HistoriaId {get; set;}
       public Historia Historia {get; set;} 


    }

}