using JSE.Web.Extensions.Lang;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace JSE.Web.Areas.Admin.ViewModel
{
    public class LoginViewModel
    {
        [Required(ErrorMessageResourceType = typeof(Mensagem), ErrorMessageResourceName = "MSG_E001")]
        [EmailAddress(ErrorMessageResourceType = typeof(Mensagem), ErrorMessageResourceName = "MSG_E004")]
        public string LoginName { get; set; }

        [Required(ErrorMessage = "Informe a senha")]
        [DisplayName("Senha")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
