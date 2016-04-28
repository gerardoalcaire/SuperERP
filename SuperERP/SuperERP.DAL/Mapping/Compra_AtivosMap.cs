using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace SuperERP.DAL.Models.Mapping
{
    public class Compra_AtivosMap : EntityTypeConfiguration<Compra_Ativos>
    {
        public Compra_AtivosMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.Detalhes)
                .HasMaxLength(300);

            // Table & Column Mappings
            this.ToTable("Compra_Ativos");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.ID_Compra).HasColumnName("ID_Compra");
            this.Property(t => t.ID_Produto).HasColumnName("ID_Produto");
            this.Property(t => t.ID_Servico).HasColumnName("ID_Servico");
            this.Property(t => t.Imposto).HasColumnName("Imposto");
            this.Property(t => t.Detalhes).HasColumnName("Detalhes");
            this.Property(t => t.Quantidade).HasColumnName("Quantidade");

            // Relationships
            this.HasRequired(t => t.Compra)
                .WithMany(t => t.Compra_Ativos)
                .HasForeignKey(d => d.ID_Compra);
            this.HasOptional(t => t.Produto)
                .WithMany(t => t.Compra_Ativos)
                .HasForeignKey(d => d.ID_Produto);
            this.HasOptional(t => t.Servico)
                .WithMany(t => t.Compra_Ativos)
                .HasForeignKey(d => d.ID_Servico);

        }
    }
}
