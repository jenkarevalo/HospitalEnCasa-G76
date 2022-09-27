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
<<<<<<< HEAD:HospiEnCasa.App.Dominio/Entidades/Historia.cs
       public int PacienteId {get; set;}
       public List<Paciente> ListaPacientes {get; set;}
=======
      
>>>>>>> 0886f3edc69dda2ea9ae55be37263b5199878e79:HospiEnCasa.App.Dominio/Entidades/Historias.cs
       public List<SugerenciaCuidado> ListaSugerenciaCuidado {get; set;}

    }
}