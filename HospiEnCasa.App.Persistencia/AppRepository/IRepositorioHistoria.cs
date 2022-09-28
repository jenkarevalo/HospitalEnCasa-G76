using System;
using HospiEnCasa.App.Dominio;

namespace HospiEnCasa.App.Persistencia
{
    public interface IRepositorioHistoria
    {
        Historia AddHistoria(Historia historia);
        void DeleteHistoria(int idHistoria);
        Historia GetHistoria(int idHistoria);
        Historia GetHistoriaAndPaciente(int idHistoria);
        IEnumerable<Historia> GetAllHistorias();
        IEnumerable<Historia> GetAllHistoriasAndPacientes();
        Historia UpdateHistoria (Historia historia);
    }
}
