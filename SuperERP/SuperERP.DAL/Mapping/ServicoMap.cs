using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace SuperERP.Web.Models.Mapping
{
    public class ServicoMap : EntityTypeConfiguration<Servico>
    {
        public ServicoMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.Nome)
                .IsRequired()
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("Servico");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.ID_Cliente).HasColumnName("ID_Cliente");
            this.Property(t => t.ID_Empresa).HasColumnName("ID_Empresa");
            this.Property(t => t.ID_Categoria_Servico).HasColumnName("ID_Categoria_Servico");
            this.Property(t => t.Nome).HasColumnName("Nome");
            this.Property(t => t.ISS).HasColumnName("ISS");
            this.Property(t => t.ICMS).HasColumnName("ICMS");
            this.Property(t => t.IVA).HasColumnName("IVA");
            this.Property(t => t.ST).HasColumnName("ST");
            this.Property(t => t.PIS).HasColumnName("PIS");
            this.Property(t => t.COFINS).HasColumnName("COFINS");
            this.Property(t => t.valor).HasColumnName("valor");
            this.Property(t => t.custo).HasColumnName("custo");

            // Relationships
            this.HasRequired(t => t.Categoria)
                .WithMany(t => t.Servicoes)
                .HasForeignKey(d => d.ID_Categoria_Servico);
            this.HasRequired(t => t.ClienteFornecedor)
                .WithMany(t => t.Servicoes)
                .HasForeignKey(d => d.ID_Cliente);
            this.HasRequired(t => t.Empresa)
                .WithMany(t => t.Servicoes)
                .HasForeignKey(d => d.ID_Empresa);

        }
    }
}
