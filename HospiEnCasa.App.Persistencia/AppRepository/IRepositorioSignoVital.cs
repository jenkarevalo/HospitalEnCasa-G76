using System;
using HospiEnCasa.App.Dominio;

namespace HospiEnCasa.App.Persistencia
{
    public interface IRepositorioSignoVital
    {
        SignoVital AddSignoVital(SignoVital signoVital);
        void DeleteSignoVital(int idSignoVital);
        SignoVital GetSignoVital(int idSignoVital);

        SignoVital GetSignoVitalAndPaciente(int idSignoVital);
        IEnumerable<SignoVital> GetAllSignosVitales();
        IEnumerable<SignoVital> GetAllSignosVitalesAndPacientes();
        IEnumerable<SignoVital> GetSignoVitalXPaciente(int idPaciente);
        SignoVital UpdateSignoVital (SignoVital signoVital);
    }
}