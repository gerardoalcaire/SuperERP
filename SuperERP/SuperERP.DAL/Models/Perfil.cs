using System;
using System.Collections.Generic;

namespace SuperERP.DAL.Models
{
    public partial class Perfil
    {
        public Perfil()
        {
            this.Usuarios = new List<Usuario>();
            this.Funcionalidades = new List<Funcionalidade>();
        }

        public int ID { get; set; }
        public string Nome { get; set; }
        public virtual ICollection<Usuario> Usuarios { get; set; }
        public virtual ICollection<Funcionalidade> Funcionalidades { get; set; }
    }
}
