using System;
using System.Collections.Generic;

namespace SuperERP.DAL.Models
{
    public partial class ClienteFornecedor
    {
        public ClienteFornecedor()
        {
            this.ClienteFornecedorEnderecoes = new List<ClienteFornecedorEndereco>();
            this.ClienteFornecedorContatoes = new List<ClienteFornecedorContato>();
            this.Compras = new List<Compra>();
            this.Ordem_Servico = new List<Ordem_Servico>();
            this.Produtoes = new List<Produto>();
            this.DadosBancariosFornClientes = new List<DadosBancariosFornCliente>();
            this.ProdutoFornecedors = new List<ProdutoFornecedor>();
            this.Servicoes = new List<Servico>();
            this.Vendas = new List<Venda>();
        }

        public int ID { get; set; }
        public Nullable<int> ID_PJ { get; set; }
        public Nullable<int> ID_PF { get; set; }
        public int Tipo { get; set; }
        public virtual ICollection<ClienteFornecedorEndereco> ClienteFornecedorEnderecoes { get; set; }
        public virtual ICollection<ClienteFornecedorContato> ClienteFornecedorContatoes { get; set; }
        public virtual PessoaFisica PessoaFisica { get; set; }
        public virtual PessoaJuridica PessoaJuridica { get; set; }
        public virtual ICollection<Compra> Compras { get; set; }
        public virtual ICollection<Ordem_Servico> Ordem_Servico { get; set; }
        public virtual ICollection<Produto> Produtoes { get; set; }
        public virtual ICollection<DadosBancariosFornCliente> DadosBancariosFornClientes { get; set; }
        public virtual ICollection<ProdutoFornecedor> ProdutoFornecedors { get; set; }
        public virtual ICollection<Servico> Servicoes { get; set; }
        public virtual ICollection<Venda> Vendas { get; set; }
    }
}
