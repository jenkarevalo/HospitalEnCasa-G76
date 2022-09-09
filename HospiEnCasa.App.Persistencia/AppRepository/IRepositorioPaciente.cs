using System;
using HospiEnCasa.App.Dominio;

namespace HospiEnCasa.App.Persistencia
{
    public interface IRepositorioPaciente
    {
        Paciente AddPaciente(Paciente paciente);
        void DeletePaciente(int idPaciente);
        Paciente GetPaciente(int idPaciente);
        IEnumerable<Paciente> GetAllPacientes();
        IEnumerable<Paciente> GetPacientesXMedico(int idPaciente);
        Paciente UpdatePaciente (Paciente paciente);    
    }
}