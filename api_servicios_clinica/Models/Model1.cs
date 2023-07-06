using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace api_servicios_clinica.Models
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<doctores> doctores { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<doctores>()
                .Property(e => e.nombre)
                .IsUnicode(false);

            modelBuilder.Entity<doctores>()
                .Property(e => e.apellidos)
                .IsUnicode(false);

            modelBuilder.Entity<doctores>()
                .Property(e => e.especialidad)
                .IsUnicode(false);

            modelBuilder.Entity<doctores>()
                .Property(e => e.turno)
                .IsUnicode(false);

            modelBuilder.Entity<doctores>()
                .Property(e => e.horario)
                .IsUnicode(false);
        }
    }
}
