using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HospiEnCasa.App.Dominio
{
    public class SignoVital
    {
       public int Id {get; set;}
       public DateTime FechaHora {get; set;}
       [Required(ErrorMessage=" El campo es obligatorio")]
       public string Signo {get; set;}
       [Required(ErrorMessage=" El campo es obligatorio")]
       public string Valor {get; set;}
       [Required(ErrorMessage=" El campo es obligatorio")]
       public int PacienteId {get; set;} 
       public Paciente Paciente{get; set;}
  

    }

}