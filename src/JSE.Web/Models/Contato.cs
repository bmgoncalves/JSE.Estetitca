using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace JSE.Web.Models
{
    public class Contato
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage ="Campo obrigatório")]
        [MaxLength(50)]
        public string Nome { get; set; }

        [MaxLength(2000)]
        public string Mensagem { get; set; }

        [MaxLength(15)]
        public string Telefone { get; set; }

        [DisplayName("Entrar em contato via Whatsapp")]
        public bool ContatoWhatsapp { get; set; }
    }
}
