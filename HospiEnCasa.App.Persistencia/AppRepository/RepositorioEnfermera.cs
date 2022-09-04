using System;
using HospiEnCasa.App.Dominio;

namespace HospiEnCasa.App.Persistencia
{
    public class RepositorioEnfermera : IRepositorioEnfermera
    {              
        private readonly AppContext _appContext;
        public RepositorioEnfermera(AppContext appContext)
        {
            this._appContext = appContext;
        }
        public Enfermera AddEnfermera (Enfermera enfermera)
        {
            var enfermeraAdicionado = this._appContext.Enfermeras.Add(enfermera);
            this._appContext.SaveChanges();
            return enfermeraAdicionado.Entity;
        }
        public void DeleteEnfermera (int idEnfermera)
        {
            var enfermeraEncontrado =this._appContext.Enfermeras.FirstOrDefault(p => p.Id == idEnfermera);
            if (enfermeraEncontrado == null)
                return;
            this._appContext.Enfermeras.Remove(enfermeraEncontrado);
            this._appContext.SaveChanges();    
        }
        public Enfermera GetEnfermera (int idEnfermera)
        {
            return _appContext.Enfermeras.FirstOrDefault(p => p.Id == idEnfermera);
        }
        public IEnumerable<Enfermera> GetAllEnfermeras()
        {
            return _appContext.Enfermeras;
        }
        public Enfermera UpdateEnfermera (Enfermera enfermera)
        {
            var enfermeraEncontrado =this._appContext.Enfermeras.FirstOrDefault(p => p.Id == enfermera.Id);
            if (enfermeraEncontrado != null)
            {
                enfermeraEncontrado.Nombre = enfermera.Nombre;
                enfermeraEncontrado.Apellido = enfermera.Apellido;
                enfermeraEncontrado.Telefono = enfermera.Telefono;
                enfermeraEncontrado.Genero = enfermera.Genero;
                enfermeraEncontrado.TarjetaProfesional = enfermera.TarjetaProfesional;
                enfermeraEncontrado.HorasLaborales = enfermera.HorasLaborales;

                _appContext.SaveChanges();
    
            }
            return enfermeraEncontrado; 
        }
    }
}