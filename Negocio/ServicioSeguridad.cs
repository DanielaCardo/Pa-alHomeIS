using Entidades;
using Repositorio;

namespace Negocio
{
    public class ServicioSeguridad : IServicioSeguridad
    {
        private IRepositorioSeguridad repositorio;

        public ServicioSeguridad(RepositorioSeguridad repositorio)
        {
            this.repositorio = repositorio;
        }

        public ServicioSeguridad()
        {
            repositorio = new RepositorioSeguridadEF();
        }

        public bool ValidarUsuario(Usuario usuario)
        {
            var usuarioActual = repositorio.ObtenerUsuario(usuario.UsuarioIngreso);
            if (usuarioActual != null)
            {
                return usuarioActual.Contraseña == usuario.Contraseña;
            }

            return false;
        }
    }
}
