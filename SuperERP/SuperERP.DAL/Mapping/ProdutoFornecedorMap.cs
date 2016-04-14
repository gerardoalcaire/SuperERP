using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace SuperERP.Web.Models.Mapping
{
    public class ProdutoFornecedorMap : EntityTypeConfiguration<ProdutoFornecedor>
    {
        public ProdutoFornecedorMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            // Table & Column Mappings
            this.ToTable("ProdutoFornecedor");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.ID_Produto).HasColumnName("ID_Produto");
            this.Property(t => t.ID_Fornecedor).HasColumnName("ID_Fornecedor");
            this.Property(t => t.Valor_Custo).HasColumnName("Valor_Custo");

            // Relationships
            this.HasRequired(t => t.ClienteFornecedor)
                .WithMany(t => t.ProdutoFornecedors)
                .HasForeignKey(d => d.ID_Fornecedor);
            this.HasRequired(t => t.Produto)
                .WithMany(t => t.ProdutoFornecedors)
                .HasForeignKey(d => d.ID_Produto);

        }
    }
}
