using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace SuperERP.Web.Models.Mapping
{
    public class ParcelamentoMap : EntityTypeConfiguration<Parcelamento>
    {
        public ParcelamentoMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            // Table & Column Mappings
            this.ToTable("Parcelamento");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.ID_Compra).HasColumnName("ID_Compra");
            this.Property(t => t.ID_Venda).HasColumnName("ID_Venda");
            this.Property(t => t.Numero_Parcela).HasColumnName("Numero_Parcela");
            this.Property(t => t.Valor).HasColumnName("Valor");
            this.Property(t => t.Pago).HasColumnName("Pago");
            this.Property(t => t.Data_Pagamento).HasColumnName("Data_Pagamento");
            this.Property(t => t.Data_Pago).HasColumnName("Data_Pago");

            // Relationships
            this.HasRequired(t => t.Compra)
                .WithMany(t => t.Parcelamentoes)
                .HasForeignKey(d => d.ID_Compra);
            this.HasRequired(t => t.Venda)
                .WithMany(t => t.Parcelamentoes)
                .HasForeignKey(d => d.ID_Venda);

        }
    }
}
