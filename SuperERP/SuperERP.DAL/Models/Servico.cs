using System;
using System.Collections.Generic;

namespace SuperERP.Web.Models
{
    public partial class Servico
    {
        public Servico()
        {
            this.Compra_Ativos = new List<Compra_Ativos>();
            this.Ordem_Servico = new List<Ordem_Servico>();
            this.Venda_Ativos = new List<Venda_Ativos>();
        }

        public int ID { get; set; }
        public int ID_Cliente { get; set; }
        public int ID_Empresa { get; set; }
        public int ID_Categoria_Servico { get; set; }
        public string Nome { get; set; }
        public double ISS { get; set; }
        public double ICMS { get; set; }
        public double IVA { get; set; }
        public double ST { get; set; }
        public double PIS { get; set; }
        public double COFINS { get; set; }
        public Nullable<double> valor { get; set; }
        public Nullable<double> custo { get; set; }
        public virtual Categoria Categoria { get; set; }
        public virtual ClienteFornecedor ClienteFornecedor { get; set; }
        public virtual ICollection<Compra_Ativos> Compra_Ativos { get; set; }
        public virtual Empresa Empresa { get; set; }
        public virtual ICollection<Ordem_Servico> Ordem_Servico { get; set; }
        public virtual ICollection<Venda_Ativos> Venda_Ativos { get; set; }
    }
}
