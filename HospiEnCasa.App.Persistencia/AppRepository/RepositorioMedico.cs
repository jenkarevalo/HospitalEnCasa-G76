using System;
using HospiEnCasa.App.Dominio;

namespace HospiEnCasa.App.Persistencia
{
    public class RepositorioMedico : IRepositorioMedico
    {              
        private readonly AppContext _appContext;
        public RepositorioMedico(AppContext appContext)
        {
            this._appContext = appContext;
        }
        public Medico AddMedico (Medico medico)
        {
            var medicoAdicionado = this._appContext.Medicos.Add(medico);
            this._appContext.SaveChanges();
            return medicoAdicionado.Entity;
        }
        public void DeleteMedico (int idMedico)
        {
            var medicoEncontrado =this._appContext.Medicos.FirstOrDefault(p => p.Id == idMedico);
            if (medicoEncontrado == null)
                return;
            this._appContext.Medicos.Remove(medicoEncontrado);
            this._appContext.SaveChanges();    
        }
        public Medico GetMedico (int idMedico)
        {
            return _appContext.Medicos.FirstOrDefault(p => p.Id == idMedico);
        }
        public IEnumerable<Medico> GetAllMedicos()
        {
            return _appContext.Medicos;
        }
        public Medico UpdateMedico (Medico medico)
        {
            var medicoEncontrado =this._appContext.Medicos.FirstOrDefault(p => p.Id == medico.Id);
            if (medicoEncontrado != null)
            {
                medicoEncontrado.Nombre = medico.Nombre;
                medicoEncontrado.Apellido = medico.Apellido;
                medicoEncontrado.Telefono = medico.Telefono;
                medicoEncontrado.Genero = medico.Genero;
                medicoEncontrado.Codigo = medico.Codigo;
                medicoEncontrado.Especialidad = medico.Especialidad;

                _appContext.SaveChanges();
    
            }
            return medicoEncontrado; 
        }
    }
}