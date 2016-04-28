using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace SuperERP.DAL.Models.Mapping
{
    public class DadosBancariosFornClienteMap : EntityTypeConfiguration<DadosBancariosFornCliente>
    {
        public DadosBancariosFornClienteMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.Banco)
                .IsRequired()
                .HasMaxLength(40);

            this.Property(t => t.Conta_Corrente)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Agencia)
                .IsRequired()
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("DadosBancariosFornCliente");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.Banco).HasColumnName("Banco");
            this.Property(t => t.Conta_Corrente).HasColumnName("Conta_Corrente");
            this.Property(t => t.Agencia).HasColumnName("Agencia");
            this.Property(t => t.ID_ClienteFornecedor).HasColumnName("ID_ClienteFornecedor");

            // Relationships
            this.HasRequired(t => t.ClienteFornecedor)
                .WithMany(t => t.DadosBancariosFornClientes)
                .HasForeignKey(d => d.ID_ClienteFornecedor);

        }
    }
}
