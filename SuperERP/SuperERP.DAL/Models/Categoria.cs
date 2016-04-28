using System;
using System.Collections.Generic;

namespace SuperERP.DAL.Models
{
    public partial class Categoria
    {
        public Categoria()
        {
            this.Produtoes = new List<Produto>();
            this.Servicoes = new List<Servico>();
        }

        public int ID { get; set; }
        public bool CategoriaTipo { get; set; }
        public string Nome { get; set; }
        public virtual ICollection<Produto> Produtoes { get; set; }
        public virtual ICollection<Servico> Servicoes { get; set; }
    }
}
