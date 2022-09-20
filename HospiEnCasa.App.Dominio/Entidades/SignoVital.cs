using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HospiEnCasa.App.Dominio
{
    public class SignoVital
    {
       public int Id {get; set;}
       [Required(ErrorMessage="El campo FechaHora es obligatorio")]
       public DateTime FechaHora {get; set;}
       [Required(ErrorMessage=" El campo es Signo obligatorio")]
       public string Signo {get; set;}
       [Required(ErrorMessage=" El campo es Valor obligatorio")]
       public string Valor {get; set;}
       public int PacienteId {get; set;} 
       public Paciente Paciente{get; set;}
  

    }

}