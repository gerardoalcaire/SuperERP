using System;
using System.Collections.Generic;

namespace SuperERP.DAL.Models
{
    public partial class Compra
    {
        public Compra()
        {
            this.Venda_Ativos = new List<Venda_Ativos>();
            this.Compra_Ativos = new List<Compra_Ativos>();
            this.Parcelamentoes = new List<Parcelamento>();
        }

        public int ID { get; set; }
        public int ID_Empresa { get; set; }
        public int ID_Fornecedor { get; set; }
        public int ID_Status { get; set; }
        public int Compra_Num { get; set; }
        public System.DateTime Data_Compra { get; set; }
        public decimal Desconto { get; set; }
        public int ID_FormaPgto { get; set; }
        public string Observacoes { get; set; }
        public int ID_conta { get; set; }
        public virtual ClienteFornecedor ClienteFornecedor { get; set; }
        public virtual ICollection<Venda_Ativos> Venda_Ativos { get; set; }
        public virtual Dados_Bancarios Dados_Bancarios { get; set; }
        public virtual Empresa Empresa { get; set; }
        public virtual Forma_Pgto Forma_Pgto { get; set; }
        public virtual Status_Venda Status_Venda { get; set; }
        public virtual ICollection<Compra_Ativos> Compra_Ativos { get; set; }
        public virtual ICollection<Parcelamento> Parcelamentoes { get; set; }
    }
}
