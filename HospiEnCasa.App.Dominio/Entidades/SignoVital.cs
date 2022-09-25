using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HospiEnCasa.App.Dominio
{
    public class SignoVital
    {
       public int Id {get; set;}
       [Required(ErrorMessage="El campo FechaHora es obligatorio")]
       public DateTime FechaHora {get; set;}

       [Required(ErrorMessage=" El campo es obligatorio")]
       public string PresionArterial {get; set;}
       [Required(ErrorMessage=" El campo es obligatorio")]
        public string Respiracion {get; set;}
       [Required(ErrorMessage=" El campo es obligatorio")]
        public string Pulso {get; set;}
       [Required(ErrorMessage=" El campo es obligatorio")]
        public string Temperatura {get; set;}
       [Required(ErrorMessage=" El campo es obligatorio")]
       public int PacienteId {get; set;} 
       public Paciente Paciente{get; set;}
  

    }

}