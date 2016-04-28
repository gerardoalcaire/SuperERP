using System;
using System.Collections.Generic;

namespace SuperERP.DAL.Models
{
    public partial class ClienteFornecedorEndereco
    {
        public int ID { get; set; }
        public string CEP { get; set; }
        public int ID_Fornecedor { get; set; }
        public string Endereco { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public virtual ClienteFornecedor ClienteFornecedor { get; set; }
    }
}
