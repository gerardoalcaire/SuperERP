using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace SuperERP.DAL.Models.Mapping
{
    public class ProdutoMap : EntityTypeConfiguration<Produto>
    {
        public ProdutoMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.Nome)
                .IsRequired()
                .HasMaxLength(255);

            this.Property(t => t.ean)
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("Produto");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.ID_Empresa).HasColumnName("ID_Empresa");
            this.Property(t => t.ID_Categoria).HasColumnName("ID_Categoria");
            this.Property(t => t.ID_Cliente).HasColumnName("ID_Cliente");
            this.Property(t => t.ID_Ncm).HasColumnName("ID_Ncm");
            this.Property(t => t.ID_Unidade_Medida).HasColumnName("ID_Unidade_Medida");
            this.Property(t => t.ICMS).HasColumnName("ICMS");
            this.Property(t => t.IPI).HasColumnName("IPI");
            this.Property(t => t.IVA).HasColumnName("IVA");
            this.Property(t => t.ST).HasColumnName("ST");
            this.Property(t => t.PIS).HasColumnName("PIS");
            this.Property(t => t.COFINS).HasColumnName("COFINS");
            this.Property(t => t.Nome).HasColumnName("Nome");
            this.Property(t => t.Codigo_Cliente).HasColumnName("Codigo_Cliente");
            this.Property(t => t.Codigo_Barras).HasColumnName("Codigo_Barras");
            this.Property(t => t.Valor_Venda).HasColumnName("Valor_Venda");
            this.Property(t => t.Estoque).HasColumnName("Estoque");
            this.Property(t => t.EstoqueMax).HasColumnName("EstoqueMax");
            this.Property(t => t.EstoqueMin).HasColumnName("EstoqueMin");
            this.Property(t => t.Peso_Liquido).HasColumnName("Peso_Liquido");
            this.Property(t => t.Peso_Bruto).HasColumnName("Peso_Bruto");
            this.Property(t => t.ean).HasColumnName("ean");

            // Relationships
            this.HasRequired(t => t.Categoria)
                .WithMany(t => t.Produtoes)
                .HasForeignKey(d => d.ID_Categoria);
            this.HasRequired(t => t.ClienteFornecedor)
                .WithMany(t => t.Produtoes)
                .HasForeignKey(d => d.ID_Cliente);
            this.HasRequired(t => t.Empresa)
                .WithMany(t => t.Produtoes)
                .HasForeignKey(d => d.ID_Empresa);
            this.HasOptional(t => t.Ncm)
                .WithMany(t => t.Produtoes)
                .HasForeignKey(d => d.ID_Ncm);
            this.HasOptional(t => t.Unidade_Medida)
                .WithMany(t => t.Produtoes)
                .HasForeignKey(d => d.ID_Unidade_Medida);

        }
    }
}
