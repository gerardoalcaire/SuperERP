using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace SuperERP.DAL.Models.Mapping
{
    public class PessoaFisicaMap : EntityTypeConfiguration<PessoaFisica>
    {
        public PessoaFisicaMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.Nome)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.CPF)
                .IsRequired()
                .HasMaxLength(11);

            this.Property(t => t.RG)
                .IsRequired()
                .HasMaxLength(11);

            // Table & Column Mappings
            this.ToTable("PessoaFisica");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.ID_Empresa).HasColumnName("ID_Empresa");
            this.Property(t => t.Nome).HasColumnName("Nome");
            this.Property(t => t.CPF).HasColumnName("CPF");
            this.Property(t => t.RG).HasColumnName("RG");

            // Relationships
            this.HasRequired(t => t.Empresa)
                .WithMany(t => t.PessoaFisicas)
                .HasForeignKey(d => d.ID_Empresa);

        }
    }
}
