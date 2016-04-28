using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace SuperERP.Web.Models.Mapping
{
    public class Forma_PgtoMap : EntityTypeConfiguration<Forma_Pgto>
    {
        public Forma_PgtoMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.Nome)
                .IsRequired()
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("Forma_Pgto");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.Nome).HasColumnName("Nome");
        }
    }
}
