using System;
using System.Collections.Generic;

namespace SuperERP.Web.Models
{
    public partial class Ordem_Servico
    {
        public int ID { get; set; }
        public int ID_Empresa { get; set; }
        public string Nome { get; set; }
        public int ID_Cliente { get; set; }
        public int ID_Servico { get; set; }
        public int ID_Status { get; set; }
        public string Numero_Os { get; set; }
        public System.DateTime DataI_Inicio { get; set; }
        public System.DateTime DataI_Entrega { get; set; }
        public string Equipamento_Recebido { get; set; }
        public string NumeroSerie { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Obs_Recebimento { get; set; }
        public string Obs_Problema { get; set; }
        public string Descr_Servico { get; set; }
        public string Obs_Interno { get; set; }
        public virtual ClienteFornecedor ClienteFornecedor { get; set; }
        public virtual Empresa Empresa { get; set; }
        public virtual Servico Servico { get; set; }
        public virtual Status_Servico Status_Servico { get; set; }
    }
}
