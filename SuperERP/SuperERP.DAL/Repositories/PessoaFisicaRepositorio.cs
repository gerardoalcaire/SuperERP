using SuperERP.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperERP.DAL.Repositories
{
    public class PessoaFisicaRepositorio : Repositorio<PessoaFisica>
    {
        public PessoaFisica ObterPorEmail(string email)
        {
            return (from pessoaFisica in dbContext.PessoaFisicas join fornecedorCliente in dbContext.ClienteFornecedors on pessoaFisica.ID equals fornecedorCliente.ID_PF
                        join contato in dbContext.ClienteFornecedorContatoes on fornecedorCliente.ID equals contato.ID_Fornecedor where contato.Email == email select pessoaFisica).FirstOrDefault();
        }

        public PessoaFisica ObterPorCPF(string cpf)
        {
            return dbContext.PessoaFisicas.FirstOrDefault(x => x.CPF == cpf);
        }
    }
}
