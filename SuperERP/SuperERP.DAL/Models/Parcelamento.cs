using System;
using System.Collections.Generic;

namespace SuperERP.Web.Models
{
    public partial class Parcelamento
    {
        public int ID { get; set; }
        public int ID_Compra { get; set; }
        public int ID_Venda { get; set; }
        public int Numero_Parcela { get; set; }
        public decimal Valor { get; set; }
        public Nullable<bool> Pago { get; set; }
        public System.DateTime Data_Pagamento { get; set; }
        public System.DateTime Data_Pago { get; set; }
        public virtual Compra Compra { get; set; }
        public virtual Venda Venda { get; set; }
    }
}
