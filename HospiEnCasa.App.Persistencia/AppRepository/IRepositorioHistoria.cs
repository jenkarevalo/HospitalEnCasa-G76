using System;
using HospiEnCasa.App.Dominio;

namespace HospiEnCasa.App.Persistencia
{
    public interface IRepositorioHistoria
    {
        Historia AddHistoria(Historia historia);
        void DeleteHistoria(int idHistoria);
        Historia GetHistoria(int idHistoria);
        IEnumerable<Historia> GetAllHistorias();
        Historia UpdateHistoria (Historia historia);
    }
}
