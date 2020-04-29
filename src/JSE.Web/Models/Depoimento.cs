using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace JSE.Web.Models
{
    public class Depoimento
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage ="Campo Obrigatório")]
        [DisplayName("Depoimento")]
        [DataType(DataType.MultilineText)]
        [MaxLength(2000)]
        public string Descricao { get; set; }

        [MaxLength(50)]
        [DisplayName("Cliente")]
        [Required(ErrorMessage = "Campo Obrigatório")]
        public string NomeCliente { get; set; }

        [DisplayName("Tel. Cel. / Whatsapp")]
        [MaxLength(18)]
        public string TelefoneCelular { get; set; }

        [DisplayName("E-mail")]
        [MaxLength(50)]
        [DataType(DataType.EmailAddress, ErrorMessage = "E-mail em formato inválido.")]
        public string Email { get; set; }

        [DisplayName("Imagem (Opcional)")]
        [MaxLength(250)]
        [DataType(DataType.ImageUrl)]
        public string Imagem { get; set; }

        public string NomeArquivo { get; set; }

        [DisplayName("Data")]
        [Required(ErrorMessage = "Campo obrigatório")]
        public DateTime DataCriacao { get; set; } = DateTime.Now;
        public bool Aprovado { get; set; } = false;

    }
}
