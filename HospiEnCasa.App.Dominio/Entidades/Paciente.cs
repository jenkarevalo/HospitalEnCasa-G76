namespace HospiEnCasa.App.Dominio
{
  public class Paciente:Persona
  {
    public int Id {get; set;}
    public string Direccion {get; set;} 
    public string Ciudad { get; set;}
    public DateTime FechaNacimiento {get; set;}
    public Historia Historia {get; set;}
    public int MedicoId {get; set;}
    public Medico Medico {get; set;} 
    public System.Nullable<int>  EnfermeraId {get; set;}
    public Enfermera Enfermera {get; set;} 
    public FamiliarDesignado FamiliarDesignado{ get; set;}
    public List<SignoVital> ListaSignoVital {get; set;}
  }
}