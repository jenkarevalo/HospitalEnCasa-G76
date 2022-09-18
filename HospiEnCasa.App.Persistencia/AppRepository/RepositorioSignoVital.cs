using System;
using HospiEnCasa.App.Dominio;

namespace HospiEnCasa.App.Persistencia
{
    public class RepositorioSignoVital : IRepositorioSignoVital
    {
        private readonly AppContext _appContext;
        public RepositorioSignoVital(AppContext appContext)
    {
        this._appContext = appContext;

    }

    public SignoVital AddSignoVital (SignoVital signoVital)
        {
           var signoVitalAdicionado = this._appContext.SignosVitales.Add(signoVital);
          this._appContext.SaveChanges();
          return signoVitalAdicionado.Entity;

        }

    public void DeleteSignoVital (int idSignoVital)
       {
            var signoVitalEncontrado =this._appContext.SignosVitales.FirstOrDefault(s => s.Id == idSignoVital);
            if (signoVitalEncontrado == null)
                return;
            this._appContext.SignosVitales.Remove(signoVitalEncontrado);
            this._appContext.SaveChanges();    
       }

       public SignoVital GetSignoVital (int idSignoVital)
       {
          return _appContext.SignosVitales.FirstOrDefault(s => s.Id == idSignoVital);
       }
    public IEnumerable<SignoVital> GetAllSignosVitales()
       {
          return _appContext.SignosVitales;
       }

    public SignoVital UpdateSignoVital (SignoVital signoVital)
       {
           var signoVitalEncontrado =this._appContext.SignosVitales.FirstOrDefault(s => s.Id == signoVital.Id);
           if (signoVitalEncontrado != null)
           {
            
            signoVitalEncontrado.Signo = signoVital.Signo;
            signoVitalEncontrado.Valor = signoVital.Valor;
            signoVitalEncontrado.Paciente = signoVital.Paciente;

            _appContext.SaveChanges();
  
           }
            return signoVitalEncontrado; 
       }    
    }
}