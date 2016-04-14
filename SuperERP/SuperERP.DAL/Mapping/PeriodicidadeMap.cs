using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace SuperERP.Web.Models.Mapping
{
    public class PeriodicidadeMap : EntityTypeConfiguration<Periodicidade>
    {
        public PeriodicidadeMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.Nome)
                .IsRequired()
                .HasMaxLength(60);

            // Table & Column Mappings
            this.ToTable("Periodicidade");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.Nome).HasColumnName("Nome");
            this.Property(t => t.Meses).HasColumnName("Meses");
        }
    }
}
