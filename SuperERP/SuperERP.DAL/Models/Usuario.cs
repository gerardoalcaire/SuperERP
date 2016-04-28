using System;
using System.Collections.Generic;

namespace SuperERP.Web.Models
{
    public partial class Usuario
    {
        public Usuario()
        {
            this.Vendas = new List<Venda>();
        }

        public int ID { get; set; }
        public int ID_Perfil { get; set; }
        public int ID_Empresa { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public virtual Empresa Empresa { get; set; }
        public virtual Perfil Perfil { get; set; }
        public virtual ICollection<Venda> Vendas { get; set; }
    }
}
