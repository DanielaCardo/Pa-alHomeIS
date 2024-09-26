using System.ComponentModel.DataAnnotations.Schema;

namespace Modelos
{
    [Table("UsuarioDelSistema")]
    public class Usuario 
    {
        public int Id { get; set; }
        public string NombreUsuario { get; set; }
        public string Clave { get; set; }
    }
}
