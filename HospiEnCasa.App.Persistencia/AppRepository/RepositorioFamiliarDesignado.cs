using System;
using HospiEnCasa.App.Dominio;

namespace HospiEnCasa.App.Persistencia
{
    public class RepositorioFamiliarDesignado: IRepositorioFamiliarDesignado
    {              
        private readonly AppContext _appContext;
        public RepositorioFamiliarDesignado(AppContext appContext)
        {
            this._appContext = appContext;
        }
        public FamiliarDesignado AddFamiliarDesignado (FamiliarDesignado familiarDesignado)
        {
            var familiarDesignadoAdicionado = this._appContext.Familiar.Add(familiarDesignado);
            this._appContext.SaveChanges();
            return familiarDesignadoAdicionado.Entity;

        }
        public void DeleteFamiliarDesignado (int idFamiliarDesignado)
        {
            var familiarDesignadoEncontrado =this._appContext.Familiar.FirstOrDefault(p => p.Id == idFamiliarDesignado);
            if (familiarDesignadoEncontrado == null)
                return;
            this._appContext.Familiar.Remove(familiarDesignadoEncontrado);
            this._appContext.SaveChanges();    
        }
        public FamiliarDesignado GetFamiliarDesignado (int idFamiliarDesignado)
        {
            return _appContext.Familiar.FirstOrDefault(p => p.Id == idFamiliarDesignado);
        }
        public IEnumerable<FamiliarDesignado> GetAllFamiliar()
        {
            return _appContext.Familiar;
        }
        public FamiliarDesignado UpdateFamiliarDesignado (FamiliarDesignado familiarDesignado)
        {
            var familiarDesignadoEncontrado =this._appContext.Familiar.FirstOrDefault(p => p.Id == familiarDesignado.Id);
            if (familiarDesignadoEncontrado != null)
            {
                familiarDesignadoEncontrado.Nombre = familiarDesignado.Nombre;
                familiarDesignadoEncontrado.Apellido = familiarDesignado.Apellido;
                familiarDesignadoEncontrado.Telefono = familiarDesignado.Telefono;
                familiarDesignadoEncontrado.Genero = familiarDesignado.Genero;
                familiarDesignadoEncontrado.Parentesco = familiarDesignado.Parentesco;
                familiarDesignadoEncontrado.Correo = familiarDesignado.Correo;
                familiarDesignadoEncontrado.PacienteId = familiarDesignado.PacienteId;

                _appContext.SaveChanges();
    
            }
            return familiarDesignadoEncontrado; 
        }
    }
}