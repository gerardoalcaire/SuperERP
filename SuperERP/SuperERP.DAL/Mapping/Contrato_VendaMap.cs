using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace SuperERP.Web.Models.Mapping
{
    public class Contrato_VendaMap : EntityTypeConfiguration<Contrato_Venda>
    {
        public Contrato_VendaMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            // Table & Column Mappings
            this.ToTable("Contrato_Venda");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.ID_Periodicidade).HasColumnName("ID_Periodicidade");
            this.Property(t => t.ID_Venda).HasColumnName("ID_Venda");
            this.Property(t => t.Dia_Cobranca).HasColumnName("Dia_Cobranca");
            this.Property(t => t.Data_Inicio).HasColumnName("Data_Inicio");
            this.Property(t => t.Data_Fim).HasColumnName("Data_Fim");
            this.Property(t => t.Juros).HasColumnName("Juros");
            this.Property(t => t.Ocorrencias).HasColumnName("Ocorrencias");

            // Relationships
            this.HasRequired(t => t.Periodicidade)
                .WithMany(t => t.Contrato_Venda)
                .HasForeignKey(d => d.ID_Periodicidade);
            this.HasRequired(t => t.Venda)
                .WithMany(t => t.Contrato_Venda)
                .HasForeignKey(d => d.ID_Venda);

        }
    }
}
