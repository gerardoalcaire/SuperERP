using System;
using System.Collections.Generic;

namespace SuperERP.DAL.Models
{
    public partial class ClienteFornecedorContato
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public int ID_Fornecedor { get; set; }
        public string Email { get; set; }
        public string Fone { get; set; }
        public string Cargo { get; set; }
        public virtual ClienteFornecedor ClienteFornecedor { get; set; }
    }
}
