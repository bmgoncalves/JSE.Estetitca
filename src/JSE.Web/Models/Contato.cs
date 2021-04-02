using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace JSE.Web.Models
{
    public class Contato
    {
        [Key]
        public int ContatoId { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        [MaxLength(50)]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        [MaxLength(20)]
        public string Assunto { get; set; }

        [MaxLength(2000)]
        [DataType(DataType.MultilineText)]
        [Required]
        public string Mensagem { get; set; }

        [MaxLength(70)]
        [DisplayName("E-mail")]
        public string Email { get; set; }

        //[MaxLength(2)]
        //[Required(ErrorMessage = "Informe o DDD")]
        //public string DDD { get; set; }

        [MaxLength(15)]
        [Required(ErrorMessage = "Informe o telefone")]
        public string Telefone { get; set; }

        [DisplayName("Entrar em contato via Whatsapp")]
        public bool ContatoWhatsapp { get; set; }

        public DateTime DataHora { get; set; } = DateTime.Now;

        public bool Pendente { get; set; } = true;

    }
}
