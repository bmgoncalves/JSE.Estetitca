using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace JSE.Web.Models
{
    public class Galeria
    {
        [Key]
        public int Id { get; set; }
        public int ServicoId { get; set; }

        [MaxLength(1000)]
        [Required(ErrorMessage = "Campo obrigatório")]
        public string Imagem { get; set; }

        [MaxLength(200)]
        public string NomeArquivo { get; set; }

        [DisplayName("Descrição")]
        [MaxLength(2000)]
        [DataType(DataType.MultilineText)]        
        public string Descricao { get; set; }
    }
}
