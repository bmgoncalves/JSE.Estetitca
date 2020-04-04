using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace JSE.Web.Models
{
    public class Estabelecimento
    {
        [Key]
        public int Id { get; set; }
        [DisplayName("Nome Fantasia")]
        [MaxLength(50)]
        [Required(ErrorMessage = "Campo obrigatório")]
        public string NomeFantasia { get; set; }
        [DisplayName("Endereço")]
        [MaxLength(50)]
        [Required(ErrorMessage = "Campo obrigatório")]
        public string Endereco { get; set; }

        [MaxLength(20)]
        [Required(ErrorMessage = "Campo obrigatório")]
        public string Bairro { get; set; }

        [MaxLength(20)]
        [Required(ErrorMessage = "Campo obrigatório")]
        public string Cidade { get; set; }

        [MaxLength(20)]
        public string Complemento { get; set; }

        [MaxLength(11)]
        [Required(ErrorMessage = "Campo obrigatório")]
        public string CEP { get; set; }

        [DisplayName("Estado")]
        [MaxLength(2)]
        [Required(ErrorMessage = "Campo obrigatório")]
        public string UF { get; set; }

        [DisplayName("País")]
        [MaxLength(30)]
        [Required(ErrorMessage = "Campo obrigatório")]
        public string Pais { get; set; }

        [DisplayName("Tel. Comercial")]
        [MaxLength(15)]
        public string TelefoneComercial { get; set; }

        [DisplayName("Tel. Cel. / Whatsapp")]
        [MaxLength(15)]
        [Required(ErrorMessage = "Campo obrigatório")]
        public string TelefoneCelular { get; set; }

        [DisplayName("E-mail")]
        [MaxLength(50)]
        [DataType(DataType.EmailAddress, ErrorMessage = "E-mail em formato inválido.")]
        [Required(ErrorMessage = "Campo obrigatório")]
        public string Email { get; set; }

        [DisplayName("Nome Fantasia")]
        [MaxLength(50)]
        [Required(ErrorMessage = "Campo obrigatório")]
        [RegularExpression(@"/^\d{2}\.\d{3}\.\d{3}\/\d{4}\-\d{2}$/", ErrorMessage = "CNPJ Inválido.")]
        public string CNPJ { get; set; }

        [DisplayName("Perfil Instagram")]
        [MaxLength(200)]
        public string UrlInstagram { get; set; }

        [DisplayName("Perfil Facebook")]
        [MaxLength(200)]
        public string UrlFacebook { get; set; }

        [DisplayName("Canal Youtube")]
        [MaxLength(200)]
        public string UrlYoutube { get; set; }

        public bool Ativo { get; set; }
    }
}
