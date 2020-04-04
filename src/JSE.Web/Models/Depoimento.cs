using Microsoft.CodeAnalysis.Operations;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

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
        public string Autor { get; set; }        

        [DisplayName("Data")]
        [Required(ErrorMessage ="Campo obrigatório")]
        public DateTime DataCriacao { get; set; }
        
    }
}
