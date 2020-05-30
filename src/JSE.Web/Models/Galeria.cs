using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JSE.Web.Models
{
    public class Galeria
    {
        [Key]
        public int GaleriaId { get; set; }

        [ForeignKey("ServicoId")]
        [DisplayName("Serviço")]
        [Required(ErrorMessage = "Campo obrigatório")]
        [Range(1, int.MaxValue, ErrorMessage = "Selecione o serviço")]
        public int ServicoId { get; set; }

        [NotMapped]
        public string NomeServico { get; set; }

        [NotMapped]
        public string NomeCategoria { get; set; }

        [MaxLength(50)]
        [DisplayName("Cliente")]
        public string NomeCliente { get; set; }

        [MaxLength(1000)]
        public string Imagem { get; set; }

        [MaxLength(200)]
        public string NomeArquivo { get; set; }

        [DisplayName("Data")]
        public DateTime DataCadastro { get; set; } = DateTime.Now;

        [DisplayName("Pagina inicial")]
        public bool Exibir { get; set; } = false;
    }
}
