using System;
using HospiEnCasa.App.Dominio;

namespace HospiEnCasa.App.Persistencia
{
    public class RepositorioPaciente : IRepositorioPaciente
    {
        private readonly AppContext _appContext;
        public RepositorioPaciente()
        { }
        public RepositorioPaciente(AppContext appContext)
        {
            this._appContext = appContext;

        }
        public Paciente AddPaciente(Paciente paciente)
        {
            var pacienteAdicionado = this._appContext.Pacientes.Add(paciente);
            this._appContext.SaveChanges();
            return pacienteAdicionado.Entity;
        }

        public void DeletePaciente(int idPaciente)
        {
            var pacienteEncontrado = this._appContext.Pacientes.FirstOrDefault(p => p.Id == idPaciente);
            if (pacienteEncontrado == null)
                return;
            this._appContext.Pacientes.Remove(pacienteEncontrado);
            this._appContext.SaveChanges();
        }
        public Paciente GetPaciente(int idPaciente)
        {
            return _appContext.Pacientes.FirstOrDefault(p => p.Id == idPaciente);
        }

        public IEnumerable<Paciente> GetAllPacientes()
        {
            return _appContext.Pacientes;
        }
        public IEnumerable<Paciente> GetPacientesXMedico(int idMedico)
        {
            Console.WriteLine("Id Medico: " + idMedico);
            return
                this._appContext.Pacientes.Where(p => p.MedicoId == idMedico);
        }
        public Paciente UpdatePaciente(Paciente paciente)
        {
            var pacienteEncontrado = this._appContext.Pacientes.FirstOrDefault(p => p.Id == paciente.Id);
            if (pacienteEncontrado != null)
            {
                pacienteEncontrado.Nombre = paciente.Nombre;
                pacienteEncontrado.Apellido = paciente.Apellido;
                pacienteEncontrado.Telefono = paciente.Telefono;
                pacienteEncontrado.Genero = paciente.Genero;
                pacienteEncontrado.Direccion = paciente.Direccion;
                pacienteEncontrado.Ciudad = paciente.Ciudad;
                pacienteEncontrado.FechaNacimiento = paciente.FechaNacimiento;
                pacienteEncontrado.FamiliarDesignado = paciente.FamiliarDesignado;
                pacienteEncontrado.Enfermera = paciente.Enfermera;
                pacienteEncontrado.Medico = paciente.Medico;
                pacienteEncontrado.Historia = paciente.Historia;

                _appContext.SaveChanges();

            }
            return pacienteEncontrado;
        }

    }
}