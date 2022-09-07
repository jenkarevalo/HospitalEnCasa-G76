using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HospiEnCasa.App.Dominio
{
    public class Medico:Persona
    {
       public int Id {get; set;}

       [Required(ErrorMessage="El campo Codigo es obligatorio")]
       public string Codigo {get; set;}
       
       [Required(ErrorMessage="El campo Codigo es obligatorio")]
       public string Especialidad {get; set;}
       public List<Paciente> ListaPacientes {get; set;}
    }
}