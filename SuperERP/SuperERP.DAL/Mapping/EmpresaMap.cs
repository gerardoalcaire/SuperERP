using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace SuperERP.DAL.Models.Mapping
{
    public class EmpresaMap : EntityTypeConfiguration<Empresa>
    {
        public EmpresaMap()
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

            this.Property(t => t.CEP)
                .IsRequired()
                .HasMaxLength(8);

            this.Property(t => t.Endereco)
                .IsRequired()
                .HasMaxLength(64);

            this.Property(t => t.Numero)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.Complemento)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.Bairro)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.Cidade)
                .IsRequired()
                .HasMaxLength(30);

            // Table & Column Mappings
            this.ToTable("Empresa");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.Nome).HasColumnName("Nome");
            this.Property(t => t.CNPJ).HasColumnName("CNPJ");
            this.Property(t => t.RazaoSocial).HasColumnName("RazaoSocial");
            this.Property(t => t.CEP).HasColumnName("CEP");
            this.Property(t => t.Endereco).HasColumnName("Endereco");
            this.Property(t => t.Numero).HasColumnName("Numero");
            this.Property(t => t.Complemento).HasColumnName("Complemento");
            this.Property(t => t.Bairro).HasColumnName("Bairro");
            this.Property(t => t.Cidade).HasColumnName("Cidade");
        }
    }
}
