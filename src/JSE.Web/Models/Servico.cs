using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

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
    }
}
