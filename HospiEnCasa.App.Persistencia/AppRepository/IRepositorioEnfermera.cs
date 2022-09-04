using System;
using HospiEnCasa.App.Dominio;

namespace HospiEnCasa.App.Persistencia
{
    public interface IRepositorioEnfermera
    {
        Enfermera AddEnfermera(Enfermera enfermera);
        void DeleteEnfermera(int idEnfermera);
        Enfermera GetEnfermera(int idEnfermera);
        IEnumerable<Enfermera> GetAllEnfermeras();
        Enfermera UpdateEnfermera (Enfermera enfermera);
    }
}