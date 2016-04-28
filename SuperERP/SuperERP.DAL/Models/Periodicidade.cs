using System;
using System.Collections.Generic;

namespace SuperERP.Web.Models
{
    public partial class Periodicidade
    {
        public Periodicidade()
        {
            this.Contrato_Venda = new List<Contrato_Venda>();
        }

        public int ID { get; set; }
        public string Nome { get; set; }
        public int Meses { get; set; }
        public virtual ICollection<Contrato_Venda> Contrato_Venda { get; set; }
    }
}
