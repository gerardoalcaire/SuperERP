using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace SuperERP.DAL.Models.Mapping
{
    public class CategoriaMap : EntityTypeConfiguration<Categoria>
    {
        public CategoriaMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.Nome)
                .IsRequired()
                .HasMaxLength(60);

            // Table & Column Mappings
            this.ToTable("Categoria");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.CategoriaTipo).HasColumnName("CategoriaTipo");
            this.Property(t => t.Nome).HasColumnName("Nome");
        }
    }
}
