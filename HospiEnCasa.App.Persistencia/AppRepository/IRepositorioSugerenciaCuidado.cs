using System;
using HospiEnCasa.App.Dominio;

namespace HospiEnCasa.App.Persistencia
{
    public interface IRepositorioSugerenciaCuidado
    {
        SugerenciaCuidado AddSugerenciaCuidado(SugerenciaCuidado sugerenciaCuidado);
        void DeleteSugerenciaCuidado(int idSugerenciaCuidado);
        SugerenciaCuidado GetSugerenciaCuidado(int idSugerenciaCuidado);
        SugerenciaCuidado GetSugerenciaCuidadoAndPaciente(int idSugerenciaCuidado);
        IEnumerable<SugerenciaCuidado> GetAllSugerenciaCuidado();
        IEnumerable<SugerenciaCuidado> GetAllSugerenciaCuidadosAndPacientes();
        IEnumerable<SugerenciaCuidado> GetSugerenciaCuidadoXPaciente(int idHistoria);
        SugerenciaCuidado UpdateSugerenciaCuidado (SugerenciaCuidado sugerenciaCuidado);
    }
}