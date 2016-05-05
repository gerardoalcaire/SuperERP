using System;
using System.Collections.Generic;

namespace SuperERP.DAL.Models
{
    public partial class Status_Venda
    {
        public Status_Venda()
        {
            this.Compras = new List<Compra>();
            this.Vendas = new List<Venda>();
        }

        public int ID { get; set; }
        public string Nome { get; set; }
        public virtual ICollection<Compra> Compras { get; set; }
        public virtual ICollection<Venda> Vendas { get; set; }
    }
}
