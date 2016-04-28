using System;
using System.Collections.Generic;

namespace SuperERP.DAL.Models
{
    public partial class Compra_Ativos
    {
        public int ID { get; set; }
        public int ID_Compra { get; set; }
        public Nullable<int> ID_Produto { get; set; }
        public Nullable<int> ID_Servico { get; set; }
        public Nullable<decimal> Imposto { get; set; }
        public string Detalhes { get; set; }
        public Nullable<int> Quantidade { get; set; }
        public virtual Compra Compra { get; set; }
        public virtual Produto Produto { get; set; }
        public virtual Servico Servico { get; set; }
    }
}
