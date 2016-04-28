using System;
using System.Collections.Generic;

namespace SuperERP.DAL.Models
{
    public partial class Empresa
    {
        public Empresa()
        {
            this.Compras = new List<Compra>();
            this.Dados_Bancarios = new List<Dados_Bancarios>();
            this.Ordem_Servico = new List<Ordem_Servico>();
            this.PessoaFisicas = new List<PessoaFisica>();
            this.PessoaJuridicas = new List<PessoaJuridica>();
            this.Produtoes = new List<Produto>();
            this.Servicoes = new List<Servico>();
            this.Usuarios = new List<Usuario>();
            this.Vendas = new List<Venda>();
        }

        public int ID { get; set; }
        public string Nome { get; set; }
        public string CNPJ { get; set; }
        public string RazaoSocial { get; set; }
        public string CEP { get; set; }
        public string Endereco { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public virtual ICollection<Compra> Compras { get; set; }
        public virtual ICollection<Dados_Bancarios> Dados_Bancarios { get; set; }
        public virtual ICollection<Ordem_Servico> Ordem_Servico { get; set; }
        public virtual ICollection<PessoaFisica> PessoaFisicas { get; set; }
        public virtual ICollection<PessoaJuridica> PessoaJuridicas { get; set; }
        public virtual ICollection<Produto> Produtoes { get; set; }
        public virtual ICollection<Servico> Servicoes { get; set; }
        public virtual ICollection<Usuario> Usuarios { get; set; }
        public virtual ICollection<Venda> Vendas { get; set; }
    }
}
