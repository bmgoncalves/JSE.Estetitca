using Microsoft.AspNetCore.Mvc;

namespace JSE.Web.Controllers
{
    public class ErrorController : Controller
    {
        [Route("Error/{statusCode}")]
        public IActionResult HttpStatusCodeHandler(int statusCode)
        {
            switch (statusCode)
            {

                case 403:
                    ViewBag.CodeError = 403;
                    ViewBag.ErrorMessage = "Desculpe, Acesso negado!";
                    break;

                case 404:
                    ViewBag.CodeError = 404;
                    ViewBag.ErrorMessage = "Oops, A página não foi encontrada!";
                    break;

                case 500:
                    ViewBag.CodeError = 500;
                    ViewBag.ErrorMessage = "Erro de Servidor Interno";
                    break;

                case 503:
                    ViewBag.CodeError = 503;
                    ViewBag.ErrorMessage = "Serviço Indisponível :( ";
                    break;
            }
            return View("Error");
        }
    }
}