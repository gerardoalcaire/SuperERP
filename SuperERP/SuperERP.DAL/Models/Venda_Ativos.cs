using System;
using System.Collections.Generic;

namespace SuperERP.Web.Models
{
    public partial class Venda_Ativos
    {
        public int ID { get; set; }
        public int ID_Venda { get; set; }
        public Nullable<int> ID_Produto { get; set; }
        public Nullable<int> ID_Servico { get; set; }
        public Nullable<int> ID_Compra { get; set; }
        public Nullable<double> Imposto { get; set; }
        public string Detalhes { get; set; }
        public Nullable<int> Quantidade { get; set; }
        public virtual Compra Compra { get; set; }
        public virtual Produto Produto { get; set; }
        public virtual Servico Servico { get; set; }
        public virtual Venda Venda { get; set; }
    }
}
