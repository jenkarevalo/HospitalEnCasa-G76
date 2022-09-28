using System;
using HospiEnCasa.App.Dominio;
using Microsoft.EntityFrameworkCore;

namespace HospiEnCasa.App.Persistencia
{
    public class RepositorioHistoria: IRepositorioHistoria
    {
        private readonly AppContext _appContext;
        public RepositorioHistoria(AppContext appContext)
        {
            this._appContext = appContext;
        }
        public Historia AddHistoria (Historia historia)
        {
            var historiaAdicionado  = this._appContext.Historias.Add(historia);
            this._appContext.SaveChanges();
            return historiaAdicionado.Entity;
        }
        public void DeleteHistoria (int idHistoria)
        {
            var historiaEncontrado =this._appContext.Historias.FirstOrDefault(p => p.Id == idHistoria);
            if (historiaEncontrado == null)
                return;
            this._appContext.Historias.Remove(historiaEncontrado);
            this._appContext.SaveChanges();
        }
        public Historia GetHistoria (int idHistoria)
        {
            return _appContext.Historias.FirstOrDefault(p => p.Id == idHistoria);
        }
        public Historia GetHistoriaAndPaciente (int idHistoria)
        {
            return _appContext.Historias.Include(V => V.Paciente).FirstOrDefault(p => p.Id == idHistoria);
        }
        public IEnumerable<Historia> GetAllHistorias()
        {
            return _appContext.Historias;
        }
         public IEnumerable<Historia> GetAllHistoriasAndPacientes()
        {
            return _appContext.Historias.Include(V => V.Paciente);
        }
        public Historia UpdateHistoria (Historia historia)
        {
            var historiaEncontrada =this._appContext.Historias.FirstOrDefault(p => p.Id == historia.Id);
            if (historiaEncontrada != null)
            {
                historiaEncontrada.Diagnostico = historia.Diagnostico;
                historiaEncontrada.Entorno = historia.Entorno;
                historiaEncontrada.PacienteId = historia.PacienteId;

                _appContext.SaveChanges();
            }
            return historiaEncontrada;
        }
    }
}