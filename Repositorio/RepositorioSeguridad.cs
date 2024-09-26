using Entidades;

namespace Repositorio
{
    public class RepositorioSeguridad : IRepositorioSeguridad
    {
        public Usuario ObtenerUsuario(string nombreUsuario)
        {
            return new Usuario() { Contraseña = "123", UsuarioIngreso = nombreUsuario };
        }
    }
}