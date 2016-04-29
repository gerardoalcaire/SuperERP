using SuperERP.Vendas;
using SuperERP.Vendas.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SuperERP.Web.Controllers
{
    public class CadastroController : Controller
    {
        public ActionResult PessoaFisica()
        {
            return View();
        }

        [HttpPost]
        public ActionResult PessoaFisica(PessoaFisicaDTO pessoa)
        {
            SuperERP.Vendas.Cadastro.PessoaFisica(pessoa);
            var pessoaFisica = SuperERP.Vendas.Listar.PessoaFisica();
            var teste = new List<string>();
            return View(pessoaFisica);
        }

        public ActionResult PessoaJuridica()
        {
            return View();
        }

        [HttpPost]
        public ActionResult PessoaJuridica(PessoaJuridicaDTO pessoa)
        {
            return View();
        }
	}
}