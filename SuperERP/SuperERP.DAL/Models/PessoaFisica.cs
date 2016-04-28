using System;
using System.Collections.Generic;

namespace SuperERP.DAL.Models
{
    public partial class PessoaFisica
    {
        public PessoaFisica()
        {
            this.ClienteFornecedors = new List<ClienteFornecedor>();
        }

        public int ID { get; set; }
        public int ID_Empresa { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string RG { get; set; }
        public virtual ICollection<ClienteFornecedor> ClienteFornecedors { get; set; }
        public virtual Empresa Empresa { get; set; }
    }
}
