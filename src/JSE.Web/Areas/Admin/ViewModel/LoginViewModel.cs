using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace JSE.Web.Areas.Admin.ViewModel
{
    public class LoginViewModel
    {
        [Required(ErrorMessage ="Informe o usuário")]
        [DisplayName("Usuário")]
        public string LoginName { get; set; }

        [Required(ErrorMessage ="Informe a senha")]
        [DisplayName("Senha")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
