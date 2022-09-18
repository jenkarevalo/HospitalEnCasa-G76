using System;
using HospiEnCasa.App.Dominio;

namespace HospiEnCasa.App.Persistencia
{
    public interface IRepositorioUsuario
    {
        Usuario AddUsuario(Usuario usuario);
        void DeleteUsuario(int idUsuaraio);
        Usuario GetUsuario(int idUsuario);
        IEnumerable<Usuario> GetAllUsuarios();
        Usuario UpdateUsuario (Usuario usuario);
    }
}