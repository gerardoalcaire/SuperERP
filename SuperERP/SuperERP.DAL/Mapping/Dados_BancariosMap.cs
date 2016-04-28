using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace SuperERP.Web.Models.Mapping
{
    public class Dados_BancariosMap : EntityTypeConfiguration<Dados_Bancarios>
    {
        public Dados_BancariosMap()
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
            this.ToTable("Dados_Bancarios");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.ID_Empresa).HasColumnName("ID_Empresa");
            this.Property(t => t.Banco).HasColumnName("Banco");
            this.Property(t => t.Conta_Corrente).HasColumnName("Conta_Corrente");
            this.Property(t => t.Agencia).HasColumnName("Agencia");

            // Relationships
            this.HasRequired(t => t.Empresa)
                .WithMany(t => t.Dados_Bancarios)
                .HasForeignKey(d => d.ID_Empresa);

        }
    }
}
