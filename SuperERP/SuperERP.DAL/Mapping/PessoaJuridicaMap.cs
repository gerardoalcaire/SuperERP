using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace SuperERP.Web.Models.Mapping
{
    public class PessoaJuridicaMap : EntityTypeConfiguration<PessoaJuridica>
    {
        public PessoaJuridicaMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.Nome)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.CNPJ)
                .IsRequired()
                .HasMaxLength(15);

            this.Property(t => t.RazaoSocial)
                .IsRequired()
                .HasMaxLength(30);

            // Table & Column Mappings
            this.ToTable("PessoaJuridica");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.ID_Empresa).HasColumnName("ID_Empresa");
            this.Property(t => t.Nome).HasColumnName("Nome");
            this.Property(t => t.CNPJ).HasColumnName("CNPJ");
            this.Property(t => t.RazaoSocial).HasColumnName("RazaoSocial");

            // Relationships
            this.HasRequired(t => t.Empresa)
                .WithMany(t => t.PessoaJuridicas)
                .HasForeignKey(d => d.ID_Empresa);

        }
    }
}
