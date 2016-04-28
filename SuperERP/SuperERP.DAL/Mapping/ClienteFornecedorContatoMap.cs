using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace SuperERP.DAL.Models.Mapping
{
    public class ClienteFornecedorContatoMap : EntityTypeConfiguration<ClienteFornecedorContato>
    {
        public ClienteFornecedorContatoMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.Nome)
                .IsRequired()
                .HasMaxLength(60);

            this.Property(t => t.Email)
                .IsRequired()
                .HasMaxLength(64);

            this.Property(t => t.Fone)
                .IsRequired()
                .HasMaxLength(15);

            this.Property(t => t.Cargo)
                .HasMaxLength(30);

            // Table & Column Mappings
            this.ToTable("ClienteFornecedorContato");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.Nome).HasColumnName("Nome");
            this.Property(t => t.ID_Fornecedor).HasColumnName("ID_Fornecedor");
            this.Property(t => t.Email).HasColumnName("Email");
            this.Property(t => t.Fone).HasColumnName("Fone");
            this.Property(t => t.Cargo).HasColumnName("Cargo");

            // Relationships
            this.HasRequired(t => t.ClienteFornecedor)
                .WithMany(t => t.ClienteFornecedorContatoes)
                .HasForeignKey(d => d.ID_Fornecedor);

        }
    }
}
