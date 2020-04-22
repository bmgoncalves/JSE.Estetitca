using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace JSE.Web.Models
{

    public class Servico
    {
        [Key]
        public int Id { get; set; }
        [DisplayName("Serviço")]
        [MaxLength(50)]
        [Required(ErrorMessage ="Campo obrigatório")]
        public string NomeServico { get; set; }

        [DisplayName("Descrição")]
        [MaxLength(200)]
        [DataType(DataType.MultilineText)]
        [Required(ErrorMessage = "Campo obrigatório")]
        public string Descricao { get; set; }

        [DisplayName("Tempo Duração")]
        [MaxLength(8)]        
        [Required(ErrorMessage = "Campo obrigatório")]
        public string Duracao { get; set; }

        [DisplayName("Imagem")]
        [MaxLength(300)]
        [Required(ErrorMessage = "Campo obrigatório")]
        public string Imagem { get; set; }
    }
}
