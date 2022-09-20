using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HospiEnCasa.App.Dominio
{
  public class Paciente:Persona
  {
    public int Id {get; set;}

    [Required(ErrorMessage="El campo Direccion es obligatorio")]
    public string Direccion {get; set;}
    [Required(ErrorMessage="El campo Ciudad es obligatorio")]
    public string Ciudad { get; set;}
    [Required(ErrorMessage="El campo Fecha de Nacimiento es obligatorio")]
    public DateTime FechaNacimiento {get; set;}
    public Historia Historia {get; set;}
    public int MedicoId {get; set;}
    public Medico Medico {get; set;} 
    public int EnfermeraId {get; set;}
    public Enfermera Enfermera {get; set;} 
    public FamiliarDesignado FamiliarDesignado{ get; set;}
    public List<SignoVital> ListaSignoVital {get; set;}
  }
}