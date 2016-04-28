using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace SuperERP.Web.Models.Mapping
{
    public class ClienteFornecedorMap : EntityTypeConfiguration<ClienteFornecedor>
    {
        public ClienteFornecedorMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            // Table & Column Mappings
            this.ToTable("ClienteFornecedor");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.ID_PJ).HasColumnName("ID_PJ");
            this.Property(t => t.ID_PF).HasColumnName("ID_PF");
            this.Property(t => t.Tipo).HasColumnName("Tipo");

            // Relationships
            this.HasOptional(t => t.PessoaFisica)
                .WithMany(t => t.ClienteFornecedors)
                .HasForeignKey(d => d.ID_PF);
            this.HasOptional(t => t.PessoaJuridica)
                .WithMany(t => t.ClienteFornecedors)
                .HasForeignKey(d => d.ID_PJ);

        }
    }
}
