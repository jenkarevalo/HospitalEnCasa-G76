using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HospiEnCasa.App.Dominio
{
    public class Historia
    {
       public int Id {get; set;}
       [Required(ErrorMessage="El campo Diagnostico es obligatorio")]
       public string Diagnostico {get; set;}
       public string Entorno {get; set;}
       public int PacienteId {get; set;}
       public List<Paciente> ListaPacientes {get; set;}
       public List<SugerenciaCuidado> ListaSugerenciaCuidado {get; set;}

    }
}