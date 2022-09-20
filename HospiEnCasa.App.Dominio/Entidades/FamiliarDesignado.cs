using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HospiEnCasa.App.Dominio
{
    public class FamiliarDesignado:Persona
    {
       public int Id {get; set;}
       public string Parentesco {get; set;}
       [Required(ErrorMessage="El campo Correo es obligatorio")] 
       public string Correo { get; set;}
       public int PacienteId {get; set;}
    }
}