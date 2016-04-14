using System;
using System.Collections.Generic;

namespace SuperERP.Web.Models
{
    public partial class Contrato_Venda
    {
        public int ID { get; set; }
        public int ID_Periodicidade { get; set; }
        public int ID_Venda { get; set; }
        public int Dia_Cobranca { get; set; }
        public System.DateTime Data_Inicio { get; set; }
        public System.DateTime Data_Fim { get; set; }
        public decimal Juros { get; set; }
        public int Ocorrencias { get; set; }
        public virtual Periodicidade Periodicidade { get; set; }
        public virtual Venda Venda { get; set; }
    }
}
