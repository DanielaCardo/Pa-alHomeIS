using Entidades;

namespace Repositorio
{
    public class RepositorioSeguridadEF : IRepositorioSeguridad
    {
        private Modelos.DBDiagramaclase dbDiagramaclase;

        public RepositorioSeguridadEF()
        {
            dbDiagramaclase = new Modelos.DBDiagramaclase();
        }

        public Usuario ObtenerUsuario(string nombreUsuario)
        {
            var usuarioActual = dbDiagramaclase.Usuarios.FirstOrDefault(u => u.UsuarioIngreso == nombreUsuario);

            if (usuarioActual != null)
            {
                return new Usuario() { UsuarioIngreso = usuarioActual.UsuarioIngreso, Contraseña = usuarioActual.Contraseña };
            }

            return null;
        }
    }
}
