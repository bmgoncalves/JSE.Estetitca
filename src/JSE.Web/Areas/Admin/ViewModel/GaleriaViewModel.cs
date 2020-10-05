using System;
using System.ComponentModel;

namespace JSE.Web.Areas.Admin.ViewModel
{
    public class GaleriaViewModel
    {
        public int GaleriaId { get; set; }
        public int ServicoId { get; set; }
        [DisplayName("Cliente")]
        public string NomeCliente { get; set; }
        [DisplayName("Serviço")]
        public string NomeServico { get; set; }
        [DisplayName("Foto")]
        public string NomeArquivo { get; set; }

        [DisplayName("Data")]
        public DateTime DataCadastro { get; set; }
        [DisplayName("Pagina inicial?")]
        public bool Exibir { get; set; }
    }
}
