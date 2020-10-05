using JSE.Web.Extensions.Lang;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JSE.Web.Models
{

    public class Servico
    {
        [Key]
        public int ServicoId { get; set; }

        [DisplayName("Serviço")]
        [MaxLength(50)]
        [Required(ErrorMessageResourceType = typeof(Mensagem), ErrorMessageResourceName = "MSG_E001")]
        public string NomeServico { get; set; }

        [ForeignKey("CategoriaId")]
        [DisplayName("Categoria")]
        [Required(ErrorMessageResourceType = typeof(Mensagem), ErrorMessageResourceName = "MSG_E001")]
        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(Mensagem), ErrorMessageResourceName = "MSG_E006")]
        public int CategoriaId { get; set; }

        public virtual ServicoCategoria Categoria { get; set; }

        [DisplayName("Descrição")]
        [MaxLength(2500)]
        [DataType(DataType.MultilineText)]
        [Required(ErrorMessageResourceType = typeof(Mensagem), ErrorMessageResourceName = "MSG_E001")]
        public string Descricao { get; set; }

        [DisplayName("Tempo Duração (Opcional)")]
        [MaxLength(8)]        
        public string Duracao { get; set; }

        [DisplayName("Imagem")]
        [MaxLength(400)]        
        public string Imagem { get; set; }

        [DisplayName("Nome Arquivo")]
        [MaxLength(50)]
        public string NomeArquivo { get; set; }

        [DisplayName("Exibir Pagina inicial")]
        public bool ExibeIndex { get; set; } = false;
        public virtual List<Galeria> Galerias { get; set; }


    }
}
