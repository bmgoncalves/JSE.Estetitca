using JSE.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JSE.Web.Areas.Admin.ViewModel
{
    public class GaleriaViewModel
    {
        public int GaleriaId { get; set; }
        public int ServicoId { get; set; }
        public string NomeCliente { get; set; }
        public string NomeServico { get; set; }

        public DateTime DataCadastro { get; set; }
        public bool Exibir { get; set; }
    }
}
