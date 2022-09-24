using System;
using HospiEnCasa.App.Dominio;

namespace HospiEnCasa.App.Persistencia
{
    public class RepositorioSugerenciaCuidado : IRepositorioSugerenciaCuidado
    {
        private readonly AppContext _appContext;
        public RepositorioSugerenciaCuidado(AppContext appContext)
        {
            this._appContext = appContext;
        }
        public SugerenciaCuidado AddSugerenciaCuidado(SugerenciaCuidado sugerenciaCuidado)
        {
            var sugerenciaCuidadoAdicionado = this._appContext.SugerenciasCuidados.Add(sugerenciaCuidado);
            this._appContext.SaveChanges();
            return sugerenciaCuidadoAdicionado.Entity;
        }
        public void DeleteSugerenciaCuidado(int idSugerenciaCuidado)
        {
            var sugerenciaCuidadoEncontrado = this._appContext.SugerenciasCuidados.FirstOrDefault(p => p.Id == idSugerenciaCuidado);
            if (sugerenciaCuidadoEncontrado == null)
                return;
            this._appContext.SugerenciasCuidados.Remove(sugerenciaCuidadoEncontrado);
            this._appContext.SaveChanges();
        }
        public SugerenciaCuidado GetSugerenciaCuidado(int idSugerenciaCuidado)
        {
            return _appContext.SugerenciasCuidados.FirstOrDefault(p => p.Id == idSugerenciaCuidado);
        }
        public IEnumerable<SugerenciaCuidado> GetAllSugerenciasCuidados()
        {
            return _appContext.SugerenciasCuidados;
        }
        public SugerenciaCuidado UpdateSugerenciaCuidado(SugerenciaCuidado sugerenciaCuidado)
        {
            var sugerenciaCuidadoEncontrado = this._appContext.SugerenciasCuidados.FirstOrDefault(p => p.Id == sugerenciaCuidado.Id);
            if (sugerenciaCuidadoEncontrado != null)
            {
                sugerenciaCuidadoEncontrado.Id = sugerenciaCuidado.Id;
                sugerenciaCuidadoEncontrado.FechaHora = sugerenciaCuidado.FechaHora;
                sugerenciaCuidadoEncontrado.Descripcion = sugerenciaCuidado.Descripcion;
                sugerenciaCuidadoEncontrado.Historia = sugerenciaCuidado.Historia;
                sugerenciaCuidadoEncontrado.HistoriaId = sugerenciaCuidado.HistoriaId;

                _appContext.SaveChanges();
            }
            return sugerenciaCuidadoEncontrado;
        }

        public IEnumerable<SugerenciaCuidado> GetAllSugerenciaCuidado()
        {
            throw new NotImplementedException();
        }
    }
}

