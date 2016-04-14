using System;
using System.Collections.Generic;

namespace SuperERP.Web.Models
{
    public partial class PessoaJuridica
    {
        public PessoaJuridica()
        {
            this.ClienteFornecedors = new List<ClienteFornecedor>();
        }

        public int ID { get; set; }
        public int ID_Empresa { get; set; }
        public string Nome { get; set; }
        public string CNPJ { get; set; }
        public string RazaoSocial { get; set; }
        public virtual ICollection<ClienteFornecedor> ClienteFornecedors { get; set; }
        public virtual Empresa Empresa { get; set; }
    }
}
