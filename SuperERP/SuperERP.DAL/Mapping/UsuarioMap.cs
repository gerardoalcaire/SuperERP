using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace SuperERP.Web.Models.Mapping
{
    public class UsuarioMap : EntityTypeConfiguration<Usuario>
    {
        public UsuarioMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.Nome)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.Email)
                .IsRequired()
                .HasMaxLength(150);

            this.Property(t => t.Senha)
                .IsRequired()
                .HasMaxLength(60);

            // Table & Column Mappings
            this.ToTable("Usuario");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.ID_Perfil).HasColumnName("ID_Perfil");
            this.Property(t => t.ID_Empresa).HasColumnName("ID_Empresa");
            this.Property(t => t.Nome).HasColumnName("Nome");
            this.Property(t => t.Email).HasColumnName("Email");
            this.Property(t => t.Senha).HasColumnName("Senha");

            // Relationships
            this.HasRequired(t => t.Empresa)
                .WithMany(t => t.Usuarios)
                .HasForeignKey(d => d.ID_Empresa);
            this.HasRequired(t => t.Perfil)
                .WithMany(t => t.Usuarios)
                .HasForeignKey(d => d.ID_Perfil);

        }
    }
}
