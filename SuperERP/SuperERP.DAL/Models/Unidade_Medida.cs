using System;
using System.Collections.Generic;

namespace SuperERP.Web.Models
{
    public partial class Unidade_Medida
    {
        public Unidade_Medida()
        {
            this.Produtoes = new List<Produto>();
        }

        public int ID { get; set; }
        public string Nome { get; set; }
        public virtual ICollection<Produto> Produtoes { get; set; }
    }
}
