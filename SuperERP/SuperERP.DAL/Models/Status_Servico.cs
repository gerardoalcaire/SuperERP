using System;
using System.Collections.Generic;

namespace SuperERP.Web.Models
{
    public partial class Status_Servico
    {
        public Status_Servico()
        {
            this.Ordem_Servico = new List<Ordem_Servico>();
        }

        public int ID { get; set; }
        public string Nome { get; set; }
        public virtual ICollection<Ordem_Servico> Ordem_Servico { get; set; }
    }
}
