using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace JSE.Web.Models
{
    public class ServicoCategoria
    {
        [Key]
        public int CategoriaId { get; set; }

        [MaxLength(50)]
        [Required(ErrorMessage = "Campo obrigatório")]
        public string Categoria { get; set; }
        public bool Ativo { get; set; } = true;
        public List<Servico> Servicos { get; set; }
    }
}
