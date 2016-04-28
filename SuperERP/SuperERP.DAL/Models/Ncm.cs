using System;
using System.Collections.Generic;

namespace SuperERP.Web.Models
{
    public partial class Ncm
    {
        public Ncm()
        {
            this.Produtoes = new List<Produto>();
        }

        public int ID { get; set; }
        public string Codico { get; set; }
        public virtual ICollection<Produto> Produtoes { get; set; }
    }
}
