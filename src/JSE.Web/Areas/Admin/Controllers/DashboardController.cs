using JSE.Web.Extensions.Login;
using JSE.Web.Models;
using JSE.Web.Repositories.Intefarces;
using Microsoft.AspNetCore.Mvc;

namespace JSE.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("{area:exists}/{controller=Dashboard}/{action=Index}/{id?}")]
    public class DashboardController : Controller
    {
        private readonly IUsuarioRepository _usuarioRepository;
        private readonly LoginUsuario _loginUsuario;

        public DashboardController(IUsuarioRepository usuarioRepository, LoginUsuario loginUsuario)
        {
            _usuarioRepository = usuarioRepository;
            _loginUsuario = loginUsuario;
        }
        public IActionResult Index()
        {
            Usuario usuario = _loginUsuario.GetUsuario();

            if (usuario != null)
            {
                return View();
            }
            return RedirectToAction(nameof(Login));
        }

        //[Route("Home/About")]
        public IActionResult Contato()
        {
            //return RedirectToAction("Index", "Contato", new { area = "Atendimento" });
            return RedirectToAction("Index", "Contato", new { area = "Admin" });
        }
        
        public IActionResult Servico()
        {
            return RedirectToAction("Index", "Servico", new { area = "Admin" });
        }


        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login([FromForm]Usuario usuario)
        {
            Usuario usuarioDB = _usuarioRepository.Login(usuario.Email, usuario.Senha);

            if (usuarioDB != null)
            {
                _loginUsuario.Login(usuarioDB);
                return RedirectToAction("Index","Dashboard");

                //return RedirectToAction("Index", "Dashboard", new { area = "Admin" });
            }
            //return RedirectToAction("Index", "Servico", new { area = "Admin" });
            return View(usuario);
        }

        public IActionResult Painel()
        {
            return new ContentResult() { Content = "Acesso permitido" };
        }

        [HttpPost]
        public IActionResult RecuperarSenha(string email)
        {
            return RedirectToAction("Index", "Servico", new { area = "Admin" });
        }

    }
}