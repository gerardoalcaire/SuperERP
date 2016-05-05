using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace SuperERP.DAL.Models.Mapping
{
    public class Ordem_ServicoMap : EntityTypeConfiguration<Ordem_Servico>
    {
        public Ordem_ServicoMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.Nome)
                .IsRequired()
                .HasMaxLength(255);

            this.Property(t => t.Numero_Os)
                .IsRequired()
                .HasMaxLength(12);

            this.Property(t => t.Equipamento_Recebido)
                .HasMaxLength(255);

            this.Property(t => t.NumeroSerie)
                .HasMaxLength(15);

            this.Property(t => t.Marca)
                .HasMaxLength(255);

            this.Property(t => t.Modelo)
                .HasMaxLength(255);

            this.Property(t => t.Obs_Recebimento)
                .HasMaxLength(500);

            this.Property(t => t.Obs_Problema)
                .HasMaxLength(500);

            this.Property(t => t.Descr_Servico)
                .HasMaxLength(500);

            this.Property(t => t.Obs_Interno)
                .HasMaxLength(500);

            // Table & Column Mappings
            this.ToTable("Ordem_Servico");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.ID_Empresa).HasColumnName("ID_Empresa");
            this.Property(t => t.Nome).HasColumnName("Nome");
            this.Property(t => t.ID_Cliente).HasColumnName("ID_Cliente");
            this.Property(t => t.ID_Servico).HasColumnName("ID_Servico");
            this.Property(t => t.ID_Status).HasColumnName("ID_Status");
            this.Property(t => t.Numero_Os).HasColumnName("Numero_Os");
            this.Property(t => t.DataI_Inicio).HasColumnName("DataI_Inicio");
            this.Property(t => t.DataI_Entrega).HasColumnName("DataI_Entrega");
            this.Property(t => t.Equipamento_Recebido).HasColumnName("Equipamento_Recebido");
            this.Property(t => t.NumeroSerie).HasColumnName("NumeroSerie");
            this.Property(t => t.Marca).HasColumnName("Marca");
            this.Property(t => t.Modelo).HasColumnName("Modelo");
            this.Property(t => t.Obs_Recebimento).HasColumnName("Obs_Recebimento");
            this.Property(t => t.Obs_Problema).HasColumnName("Obs_Problema");
            this.Property(t => t.Descr_Servico).HasColumnName("Descr_Servico");
            this.Property(t => t.Obs_Interno).HasColumnName("Obs_Interno");

            // Relationships
            this.HasRequired(t => t.ClienteFornecedor)
                .WithMany(t => t.Ordem_Servico)
                .HasForeignKey(d => d.ID_Cliente);
            this.HasRequired(t => t.Empresa)
                .WithMany(t => t.Ordem_Servico)
                .HasForeignKey(d => d.ID_Empresa);
            this.HasRequired(t => t.Servico)
                .WithMany(t => t.Ordem_Servico)
                .HasForeignKey(d => d.ID_Servico);
            this.HasRequired(t => t.Status_Servico)
                .WithMany(t => t.Ordem_Servico)
                .HasForeignKey(d => d.ID_Status);

        }
    }
}
