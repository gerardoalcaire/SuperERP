using System;
using System.Collections.Generic;

namespace SuperERP.DAL.Models
{
    public partial class Funcionalidade
    {
        public Funcionalidade()
        {
            this.Perfils = new List<Perfil>();
        }

        public int ID { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public virtual ICollection<Perfil> Perfils { get; set; }
    }
}
