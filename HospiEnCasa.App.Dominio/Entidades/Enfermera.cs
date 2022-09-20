using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HospiEnCasa.App.Dominio
{
    public class Enfermera:Persona
    {
       public int Id {get; set;}
       [Required(ErrorMessage="El campo Numero de Tarjeta Profesional es obligatorio")]
       public string TarjetaProfesional {get; set;}
       [Required(ErrorMessage="El campo Horas Laborales es obligatorio")]
       public int HorasLaborales {get; set;}
       public List<Paciente> ListaPacientes {get; set;}
    }
}