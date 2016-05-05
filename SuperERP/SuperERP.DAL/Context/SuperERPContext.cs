using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using SuperERP.DAL.Models.Mapping;
using SuperERP.DAL.Models;

namespace SuperERP.DAL.Context
{
    public class SuperERPContext : DbContext
    {
        static SuperERPContext()
        {
            Database.SetInitializer<SuperERPContext>(null);
        }

        public SuperERPContext()
            : base("Name=SuperERPContext")
        {
            Configuration.LazyLoadingEnabled = false;
        }

        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<ClienteFornecedor> ClienteFornecedors { get; set; }
        public DbSet<ClienteFornecedorContato> ClienteFornecedorContatoes { get; set; }
        public DbSet<ClienteFornecedorEndereco> ClienteFornecedorEnderecoes { get; set; }
        public DbSet<Compra> Compras { get; set; }
        public DbSet<Compra_Ativos> Compra_Ativos { get; set; }
        public DbSet<Contrato_Venda> Contrato_Venda { get; set; }
        public DbSet<Dados_Bancarios> Dados_Bancarios { get; set; }
        public DbSet<DadosBancariosFornCliente> DadosBancariosFornClientes { get; set; }
        public DbSet<Empresa> Empresas { get; set; }
        public DbSet<Forma_Pgto> Forma_Pgto { get; set; }
        public DbSet<Funcionalidade> Funcionalidades { get; set; }
        public DbSet<Ncm> Ncms { get; set; }
        public DbSet<Ordem_Servico> Ordem_Servico { get; set; }
        public DbSet<Parcelamento> Parcelamentoes { get; set; }
        public DbSet<Perfil> Perfils { get; set; }
        public DbSet<Periodicidade> Periodicidades { get; set; }
        public DbSet<PessoaFisica> PessoaFisicas { get; set; }
        public DbSet<PessoaJuridica> PessoaJuridicas { get; set; }
        public DbSet<Produto> Produtoes { get; set; }
        public DbSet<ProdutoFornecedor> ProdutoFornecedors { get; set; }
        public DbSet<Servico> Servicoes { get; set; }
        public DbSet<Status_Servico> Status_Servico { get; set; }
        public DbSet<Status_Venda> Status_Venda { get; set; }
        public DbSet<Unidade_Medida> Unidade_Medida { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Venda> Vendas { get; set; }
        public DbSet<Venda_Ativos> Venda_Ativos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new CategoriaMap());
            modelBuilder.Configurations.Add(new ClienteFornecedorMap());
            modelBuilder.Configurations.Add(new ClienteFornecedorContatoMap());
            modelBuilder.Configurations.Add(new ClienteFornecedorEnderecoMap());
            modelBuilder.Configurations.Add(new CompraMap());
            modelBuilder.Configurations.Add(new Compra_AtivosMap());
            modelBuilder.Configurations.Add(new Contrato_VendaMap());
            modelBuilder.Configurations.Add(new Dados_BancariosMap());
            modelBuilder.Configurations.Add(new DadosBancariosFornClienteMap());
            modelBuilder.Configurations.Add(new EmpresaMap());
            modelBuilder.Configurations.Add(new Forma_PgtoMap());
            modelBuilder.Configurations.Add(new FuncionalidadeMap());
            modelBuilder.Configurations.Add(new NcmMap());
            modelBuilder.Configurations.Add(new Ordem_ServicoMap());
            modelBuilder.Configurations.Add(new ParcelamentoMap());
            modelBuilder.Configurations.Add(new PerfilMap());
            modelBuilder.Configurations.Add(new PeriodicidadeMap());
            modelBuilder.Configurations.Add(new PessoaFisicaMap());
            modelBuilder.Configurations.Add(new PessoaJuridicaMap());
            modelBuilder.Configurations.Add(new ProdutoMap());
            modelBuilder.Configurations.Add(new ProdutoFornecedorMap());
            modelBuilder.Configurations.Add(new ServicoMap());
            modelBuilder.Configurations.Add(new Status_ServicoMap());
            modelBuilder.Configurations.Add(new Status_VendaMap());
            modelBuilder.Configurations.Add(new Unidade_MedidaMap());
            modelBuilder.Configurations.Add(new UsuarioMap());
            modelBuilder.Configurations.Add(new VendaMap());
            modelBuilder.Configurations.Add(new Venda_AtivosMap());
        }
    }
}
