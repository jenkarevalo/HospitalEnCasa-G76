using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HospiEnCasa.App.Dominio
{
    public class Persona
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El campo Nombre es obligatorio")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "El campo Apellido es obligatorio")]
        public string Apellido { get; set; }
        public string Telefono { get; set; }
        public Genero Genero { get; set; }
    }

}