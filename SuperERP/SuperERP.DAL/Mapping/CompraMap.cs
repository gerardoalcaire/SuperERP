using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace SuperERP.Web.Models.Mapping
{
    public class CompraMap : EntityTypeConfiguration<Compra>
    {
        public CompraMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.Observacoes)
                .IsRequired()
                .HasMaxLength(300);

            // Table & Column Mappings
            this.ToTable("Compra");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.ID_Empresa).HasColumnName("ID_Empresa");
            this.Property(t => t.ID_Fornecedor).HasColumnName("ID_Fornecedor");
            this.Property(t => t.ID_Status).HasColumnName("ID_Status");
            this.Property(t => t.Compra_Num).HasColumnName("Compra_Num");
            this.Property(t => t.Data_Compra).HasColumnName("Data_Compra");
            this.Property(t => t.Desconto).HasColumnName("Desconto");
            this.Property(t => t.ID_FormaPgto).HasColumnName("ID_FormaPgto");
            this.Property(t => t.Observacoes).HasColumnName("Observacoes");
            this.Property(t => t.ID_conta).HasColumnName("ID_conta");

            // Relationships
            this.HasRequired(t => t.ClienteFornecedor)
                .WithMany(t => t.Compras)
                .HasForeignKey(d => d.ID_Fornecedor);
            this.HasRequired(t => t.Dados_Bancarios)
                .WithMany(t => t.Compras)
                .HasForeignKey(d => d.ID_conta);
            this.HasRequired(t => t.Empresa)
                .WithMany(t => t.Compras)
                .HasForeignKey(d => d.ID_Empresa);
            this.HasRequired(t => t.Forma_Pgto)
                .WithMany(t => t.Compras)
                .HasForeignKey(d => d.ID_FormaPgto);
            this.HasRequired(t => t.Status_Venda)
                .WithMany(t => t.Compras)
                .HasForeignKey(d => d.ID_Status);

        }
    }
}
