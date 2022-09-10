// See https://aka.ms/new-console-template for more information
using System;
using HospiEnCasa.App.Dominio;
using HospiEnCasa.App.Persistencia;

public class Program
{
   private static IRepositorioPaciente _repositorioPaciente = new RepositorioPaciente(new HospiEnCasa.App.Persistencia.AppContext());
   private static IRepositorioMedico _repositorioMedico = new RepositorioMedico(new HospiEnCasa.App.Persistencia.AppContext());
   private static IRepositorioEnfermera _repositorioEnfermera = new RepositorioEnfermera(new HospiEnCasa.App.Persistencia.AppContext());
   private static IRepositorioFamiliarDesignado _repositorioFamiliarDesignado = new RepositorioFamiliarDesignado(new HospiEnCasa.App.Persistencia.AppContext());
   private static void Main(String[] args)
   {
      Console.WriteLine("Hello, World!");

      //AdicionarPaciente();
      //BuscarPaciente();
      //VerListadoPacientes();
      //AdicionarMedico();
      //BuscarMedico();
      //AdicionarEnfermera();
      //BuscarEnfermera();
      //AdicionarFamiliarDesignado();
      //BuscarFamiliarDesignado();
      //EscogerMedico();
      EscogerEnfermera();
   }

   public static void EscogerEnfermera()
   {
      Enfermera enfermera = _repositorioEnfermera.GetEnfermera(2);
      Console.WriteLine("Enfermera: " + enfermera.Nombre);
      enfermera.ListaPacientes = _repositorioPaciente.GetPacientesXEnfermera(enfermera.Id).ToList();

      Paciente paciente = new Paciente();
      paciente.Nombre = "Andres";
      paciente.Apellido = "Perez";
      paciente.Telefono = "3001254789";
      paciente.Genero = Genero.masculino;
      paciente.Direccion = "calle 188 # 08-15";
      paciente.Ciudad = "Bogota";
      paciente.FechaNacimiento = new DateTime(1982, 12, 21);
      paciente.MedicoId = 2;

      paciente.Enfermera = enfermera;
      enfermera.ListaPacientes.Add(paciente);

      _repositorioEnfermera.UpdateEnfermera(enfermera);
      Console.WriteLine("Accion realizada");
   }
   public static void EscogerMedico()
   {
      Medico medico = _repositorioMedico.GetMedico(2);
      Console.WriteLine("Medico: " + medico.Nombre);
      medico.ListaPacientes = _repositorioPaciente.GetPacientesXMedico(medico.Id).ToList();

      Paciente paciente = new Paciente();
      paciente.Nombre = "Jose";
      paciente.Apellido = "Osorio";
      paciente.Telefono = "3216874862";
      paciente.Genero = Genero.masculino;
      paciente.Direccion = "calle 127 # 12-05";
      paciente.Ciudad = "Bogota";
      paciente.FechaNacimiento = new DateTime(1987, 08, 12);

      paciente.Medico = medico;
      medico.ListaPacientes.Add(paciente);

      _repositorioMedico.UpdateMedico(medico);
      Console.WriteLine("Accion realizada");
   }
   static void AdicionarPaciente()
   {
      Console.WriteLine("Adicionando un Paciente");
      Paciente paciente = new Paciente();
      paciente.Nombre = "Ale";
      paciente.Apellido = "Cabas";
      paciente.Telefono = "315282567";
      paciente.Genero = Genero.femenino;
      paciente.Direccion = "Calle 256No. 13-48";
      paciente.Ciudad = "Santa Marta";
      paciente.FechaNacimiento = DateTime.Now;

      _repositorioPaciente.AddPaciente(paciente);
      Console.WriteLine("Paciente Adicionado Correctamente");
   }
   static void BuscarPaciente()
   {
      var paciente = _repositorioPaciente.GetPaciente(1);
      Console.WriteLine("Nombre: " + paciente.Nombre);
      Console.WriteLine("Apellido: " + paciente.Apellido);
   }

   static void VerListadoPacientes()
   {
      var lspacientes = _repositorioPaciente.GetAllPacientes();
      foreach (var paciente in lspacientes)
      {
         Console.WriteLine("Nombre: " + paciente.Nombre);
         Console.WriteLine("Telefono: " + paciente.Telefono);
      }
   }
   static void AdicionarMedico()
   {
      Console.WriteLine("Adicionando un Medico");
      Medico medico = new Medico();
      medico.Nombre = "Juan";
      medico.Apellido = "Rivera";
      medico.Telefono = "3171596482";
      medico.Genero = Genero.masculino;
      medico.Codigo = "15415123";
      medico.Especialidad = "Ortopedia";

      _repositorioMedico.AddMedico(medico);
      Console.WriteLine("Medico Adicionado Correctamente");
   }
   static void BuscarMedico()
   {
      var medico = _repositorioMedico.GetMedico(1);
      Console.WriteLine("Nombre: " + medico.Nombre);
      Console.WriteLine("Apellido: " + medico.Apellido);
   }
   static void VerListadoMedico()
   {
      var lsMedicos = _repositorioMedico.GetAllMedicos();
      foreach (var medico in lsMedicos)
      {
         Console.WriteLine("Nombre: " + medico.Nombre);
         Console.WriteLine("Telefono: " + medico.Telefono);
      }
   }
   static void AdicionarEnfermera()
   {
      Console.WriteLine("Adicionando una Enfermera");
      Enfermera enfermera = new Enfermera();
      enfermera.Nombre = "Rosa";
      enfermera.Apellido = "Ortega";
      enfermera.Telefono = "3208714963";
      enfermera.Genero = Genero.femenino;
      enfermera.TarjetaProfesional = "15415123";
      enfermera.HorasLaborales = 545;

      _repositorioEnfermera.AddEnfermera(enfermera);
      Console.WriteLine("Enfermera Adicionado Correctamente");
   }
   static void BuscarEnfermera()
   {
      var enfermera = _repositorioEnfermera.GetEnfermera(1);
      Console.WriteLine(enfermera.Nombre + " " + enfermera.Apellido);
      Console.WriteLine("TarjetaProfesional: " + enfermera.TarjetaProfesional);
   }
   static void AdicionarFamiliarDesignado()
   {
      Console.WriteLine("Adicionando un Familiar Designado");
      FamiliarDesignado familiarDesignado = new FamiliarDesignado();
      familiarDesignado.Nombre = "Rodrigo";
      familiarDesignado.Apellido = "Alvarez";
      familiarDesignado.Telefono = "3025896715";
      familiarDesignado.Genero = Genero.masculino;
      familiarDesignado.Parentesco = "Hermano";
      familiarDesignado.Correo = "Rodri.al@gmail.com";
      familiarDesignado.PacienteId = 1;

      _repositorioFamiliarDesignado.AddFamiliarDesignado(familiarDesignado);
      Console.WriteLine("Familiar Designado Adicionado Correctamente");
   }
   static void BuscarFamiliarDesignado()
   {
      var familiarDesignado = _repositorioFamiliarDesignado.GetFamiliarDesignado(4);
      Console.WriteLine(familiarDesignado.Nombre + " " + familiarDesignado.Apellido);
      Console.WriteLine("Parentesco: " + familiarDesignado.Parentesco);
   }
}