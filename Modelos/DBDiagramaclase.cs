using System.Collections.Generic;
using System.Reflection.Emit;

namespace Modelos
{
    public class DBDiagramaclase : DbContext
    {
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<SolicitudDomicilio> SolicitudesDomicilio { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            builder.UseSqlServer(ConfigurationManager.ConnectionStrings["Diagramaclase"].ConnectionString);
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<SolicitudDomicilio>()
                .HasMany(e => e.Usuarios)
                .WithOne(e => e.SolicitudDomicilio)
                .HasForeignKey(e => e.idSolicitudDomicilio);

           
        }
    }
}