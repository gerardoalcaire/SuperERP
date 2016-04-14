using System;
using System.Collections.Generic;

namespace SuperERP.Web.Models
{
    public partial class ProdutoFornecedor
    {
        public int ID { get; set; }
        public int ID_Produto { get; set; }
        public int ID_Fornecedor { get; set; }
        public double Valor_Custo { get; set; }
        public virtual ClienteFornecedor ClienteFornecedor { get; set; }
        public virtual Produto Produto { get; set; }
    }
}
