using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace SuperERP.Web.Models.Mapping
{
    public class NcmMap : EntityTypeConfiguration<Ncm>
    {
        public NcmMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.Codico)
                .IsRequired()
                .HasMaxLength(15);

            // Table & Column Mappings
            this.ToTable("Ncm");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.Codico).HasColumnName("Codico");
        }
    }
}
