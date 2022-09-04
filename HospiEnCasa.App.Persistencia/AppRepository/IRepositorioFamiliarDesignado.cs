using System;
using HospiEnCasa.App.Dominio;

namespace HospiEnCasa.App.Persistencia
{
    public interface IRepositorioFamiliarDesignado
    {
        FamiliarDesignado AddFamiliarDesignado(FamiliarDesignado familiarDesignado);
        void DeleteFamiliarDesignado(int idFamiliarDesignado);
        FamiliarDesignado GetFamiliarDesignado(int idFamiliarDesignado);
        IEnumerable<FamiliarDesignado> GetAllFamiliar();
        FamiliarDesignado UpdateFamiliarDesignado (FamiliarDesignado familiarDesignado);
    }
}