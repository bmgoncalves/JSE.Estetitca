using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
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
        [MaxLength(2500)]
        [DataType(DataType.MultilineText)]
        [Required(ErrorMessage = "Campo obrigatório")]
        public string Descricao { get; set; }

        [DisplayName("Tempo Duração (Opcional)")]
        [MaxLength(8)]        
        public string Duracao { get; set; }

        [DisplayName("Imagem")]
        [MaxLength(400)]        
        public string Imagem { get; set; }

        [DisplayName("Exibir Pagina inicial")]
        public bool ExibeIndex { get; set; } = false;

    }
}
