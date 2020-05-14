using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace JSE.Web.Models
{
    public class Usuario
    {
        [Key]
        public int UsuarioId { get; set; }

        [DisplayName("Nome")]
        [Required(ErrorMessage ="Campo obrigatório")]
        [MaxLength(30)]
        public string Nome { get; set; }

        [DisplayName("E-mail")]
        [MaxLength(50)]
        [Required(ErrorMessage = "Campo obrigatório")]
        [DataType(DataType.EmailAddress, ErrorMessage = "E-mail em formato inválido.")]
        public string Email { get; set; }

        [DisplayName("Senha")]
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Campo obrigatório")]
        [MaxLength(15)]
        public string Senha { get; set; }
    }
}
