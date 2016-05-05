using System;
using System.Collections.Generic;

namespace SuperERP.DAL.Models
{
    public partial class DadosBancariosFornCliente
    {
        public int ID { get; set; }
        public string Banco { get; set; }
        public string Conta_Corrente { get; set; }
        public string Agencia { get; set; }
        public int ID_ClienteFornecedor { get; set; }
        public virtual ClienteFornecedor ClienteFornecedor { get; set; }
    }
}
