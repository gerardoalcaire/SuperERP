using System;
using System.Collections.Generic;

namespace SuperERP.DAL.Models
{
    public partial class Dados_Bancarios
    {
        public Dados_Bancarios()
        {
            this.Compras = new List<Compra>();
            this.Vendas = new List<Venda>();
        }

        public int ID { get; set; }
        public int ID_Empresa { get; set; }
        public string Banco { get; set; }
        public string Conta_Corrente { get; set; }
        public string Agencia { get; set; }
        public virtual ICollection<Compra> Compras { get; set; }
        public virtual Empresa Empresa { get; set; }
        public virtual ICollection<Venda> Vendas { get; set; }
    }
}
