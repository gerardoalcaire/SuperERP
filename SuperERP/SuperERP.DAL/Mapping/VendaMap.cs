using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace SuperERP.Web.Models.Mapping
{
    public class VendaMap : EntityTypeConfiguration<Venda>
    {
        public VendaMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.Observacoes)
                .IsRequired()
                .HasMaxLength(300);

            // Table & Column Mappings
            this.ToTable("Venda");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.ID_Empresa).HasColumnName("ID_Empresa");
            this.Property(t => t.ID_Usuario).HasColumnName("ID_Usuario");
            this.Property(t => t.ID_Cliente).HasColumnName("ID_Cliente");
            this.Property(t => t.ID_Orcamento).HasColumnName("ID_Orcamento");
            this.Property(t => t.ID_Status).HasColumnName("ID_Status");
            this.Property(t => t.ID_conta).HasColumnName("ID_conta");
            this.Property(t => t.ID_FormaPgto).HasColumnName("ID_FormaPgto");
            this.Property(t => t.Venda_Num).HasColumnName("Venda_Num");
            this.Property(t => t.Data_Venda).HasColumnName("Data_Venda");
            this.Property(t => t.Contrato).HasColumnName("Contrato");
            this.Property(t => t.Desconto).HasColumnName("Desconto");
            this.Property(t => t.Observacoes).HasColumnName("Observacoes");

            // Relationships
            this.HasRequired(t => t.ClienteFornecedor)
                .WithMany(t => t.Vendas)
                .HasForeignKey(d => d.ID_Cliente);
            this.HasRequired(t => t.Dados_Bancarios)
                .WithMany(t => t.Vendas)
                .HasForeignKey(d => d.ID_conta);
            this.HasRequired(t => t.Empresa)
                .WithMany(t => t.Vendas)
                .HasForeignKey(d => d.ID_Empresa);
            this.HasRequired(t => t.Forma_Pgto)
                .WithMany(t => t.Vendas)
                .HasForeignKey(d => d.ID_FormaPgto);
            this.HasRequired(t => t.Status_Venda)
                .WithMany(t => t.Vendas)
                .HasForeignKey(d => d.ID_Status);
            this.HasRequired(t => t.Usuario)
                .WithMany(t => t.Vendas)
                .HasForeignKey(d => d.ID_Usuario);
            this.HasOptional(t => t.Venda2)
                .WithMany(t => t.Venda1)
                .HasForeignKey(d => d.ID_Orcamento);

        }
    }
}
