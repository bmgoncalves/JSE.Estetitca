using JSE.Web.Extensions.Login;
using JSE.Web.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;

namespace JSE.Web.Extensions.Filtro
{
    /*
     * Tipos de filtros 
     *  - Autorização - IAuthorizationFilter
     *  - Recursos - IResourceFilter
     *  - Ação - IActionFilter
     *  - Exceção - IExceptionFilter
     *  - Resultado - IResultFilter
     */
    public class UsuarioAutorizacaoAttribute : Attribute, IAuthorizationFilter
    {
        private LoginUsuario _loginUsuario;
        public void OnAuthorization(AuthorizationFilterContext context)
        {

            /* Chama para não ter que instanciar LoginUsuario no construtor, pois com isso a cada chamada teria que instanciar novamente.
             * Desta forma com o HttpContext é possivel requisitar o serviço via injeção de dependencia pois a classe foi definida como 
             * serviço na startup.cs*/
            _loginUsuario = (LoginUsuario)context.HttpContext.RequestServices.GetService(typeof(LoginUsuario));

            Usuario usuario = _loginUsuario.GetUsuario();
            if (usuario == null)
            {
                context.Result = new RedirectToActionResult("Login", "Dashboard", null);
            }
        }
    }
}
