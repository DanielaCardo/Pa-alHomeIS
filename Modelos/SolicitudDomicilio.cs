using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Modelos
{
    [Table("SolicitudDomicilio")]
    public class SolicitudDomicilio
    {
        public int idSolicitudDomicilio { get; set; }
        public int codSolicitudDomicilio { get; set; }
        public int idDomicilioAsignado { get; set; }
        public int idFormula { get; set; }
        public string direccion { get; set; }

        public virtual ICollection<Usuario> Usuarios { get; set; }
    }
}
