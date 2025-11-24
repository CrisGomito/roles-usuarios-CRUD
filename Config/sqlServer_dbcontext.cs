
using Microsoft.EntityFrameworkCore;
using System.Configuration;
using CRUD_Semana5.Modelos;

namespace CRUD_Semana5.Config
{
    public class sqlServer_dbcontext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                var cn = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
                optionsBuilder.UseSqlServer(cn);
            }
        }
        public DbSet<Rol_Model> Roles { get; set; }

        public DbSet<Usuario_Model> Usuarios { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Rol_Model>(entity =>
            {
                entity.ToTable("Roles");
                entity.HasKey(r => r.Id_Rol);
                entity.Property(r => r.Nombre_Rol).HasMaxLength(50).IsRequired();
                entity.Property(r => r.Descripcion).HasMaxLength(250);
            });

            modelBuilder.Entity<Usuario_Model>(entity =>
            {
                entity.ToTable("Usuarios");
                entity.HasKey(u => u.Id_Usuario);
                entity.Property(u => u.Nombre_Usuario).HasMaxLength(50).IsRequired();
                entity.Property(u => u.Apellido_Usuario).HasMaxLength(50).IsRequired();
                entity.Property(u => u.Correo_Usuario).HasMaxLength(100).IsRequired();
                entity.HasOne<Rol_Model>()
                      .WithMany()
                      .HasForeignKey(u => u.Id_Rol)
                      .HasConstraintName("FK_Usuarios_Roles");
            });
        }
    }
}
