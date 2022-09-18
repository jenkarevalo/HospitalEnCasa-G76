using System;
using HospiEnCasa.App.Dominio;

namespace HospiEnCasa.App.Persistencia
{
    public class RepositorioUsuario : IRepositorioUsuario
    {              
        private readonly AppContext _appContext;
        public RepositorioUsuario(AppContext appContext)
        {
            this._appContext = appContext;
        }
       
       
        public Usuario AddUsuario (Usuario usuario)
        {
            var usuarioAdicionado = this._appContext.Usuarios.Add(usuario);
            this._appContext.SaveChanges();
            return usuarioAdicionado.Entity;
        }
        public void DeleteUsuario (int idUsuario)
        {
            var usuarioEncontrado =this._appContext.Usuarios.FirstOrDefault(p => p.Id == idUsuario);
            if (usuarioEncontrado == null)
                return;
            this._appContext.Usuarios.Remove(usuarioEncontrado);
            this._appContext.SaveChanges();    
        }
        public Usuario GetUsuario (int idUsuario)
        {
            return _appContext.Usuarios.FirstOrDefault(p => p.Id == idUsuario);
        }
        public IEnumerable<Usuario> GetAllUsuarios()
        {
            return _appContext.Usuarios;
        }
        public Usuario UpdateUsuario (Usuario usuario)
        {
            var usuarioEncontrado =this._appContext.Usuarios.FirstOrDefault(p => p.Id == usuario.Id);
            if (usuarioEncontrado != null)
            {
                usuarioEncontrado.User = usuario.User;
                usuarioEncontrado.Password = usuario.Password;
                

                _appContext.SaveChanges();
    
            }
            return usuarioEncontrado; 
        }
    }
}