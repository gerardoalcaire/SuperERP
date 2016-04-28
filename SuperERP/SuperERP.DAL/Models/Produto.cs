using System;
using System.Collections.Generic;

namespace SuperERP.Web.Models
{
    public partial class Produto
    {
        public Produto()
        {
            this.Compra_Ativos = new List<Compra_Ativos>();
            this.ProdutoFornecedors = new List<ProdutoFornecedor>();
            this.Venda_Ativos = new List<Venda_Ativos>();
        }

        public int ID { get; set; }
        public int ID_Empresa { get; set; }
        public int ID_Categoria { get; set; }
        public int ID_Cliente { get; set; }
        public Nullable<int> ID_Ncm { get; set; }
        public Nullable<int> ID_Unidade_Medida { get; set; }
        public double ICMS { get; set; }
        public double IPI { get; set; }
        public double IVA { get; set; }
        public double ST { get; set; }
        public double PIS { get; set; }
        public double COFINS { get; set; }
        public string Nome { get; set; }
        public int Codigo_Cliente { get; set; }
        public int Codigo_Barras { get; set; }
        public double Valor_Venda { get; set; }
        public int Estoque { get; set; }
        public int EstoqueMax { get; set; }
        public int EstoqueMin { get; set; }
        public Nullable<double> Peso_Liquido { get; set; }
        public Nullable<double> Peso_Bruto { get; set; }
        public string ean { get; set; }
        public virtual Categoria Categoria { get; set; }
        public virtual ClienteFornecedor ClienteFornecedor { get; set; }
        public virtual ICollection<Compra_Ativos> Compra_Ativos { get; set; }
        public virtual Empresa Empresa { get; set; }
        public virtual Ncm Ncm { get; set; }
        public virtual Unidade_Medida Unidade_Medida { get; set; }
        public virtual ICollection<ProdutoFornecedor> ProdutoFornecedors { get; set; }
        public virtual ICollection<Venda_Ativos> Venda_Ativos { get; set; }
    }
}
