using JSE.Web.Areas.Admin.ViewModel;
using JSE.Web.Extensions;
using JSE.Web.Extensions.Filtro;
using JSE.Web.Extensions.Login;
using JSE.Web.Models;
using JSE.Web.Repositories.Intefarces;
using Microsoft.AspNetCore.Mvc;

namespace JSE.Web.Areas.Admin.Controllers
{
    //TODO - Criar rotina para reenviar senha de e-mail usando o e-mail do dominio
    [Area("Admin")]
    [Route("{area:exists}/{controller=Login}/{action=Login}")]
    [Route("{area:exists}/{controller=Login}/{action=Login}/{id}")]
    public class LoginController : Controller
    {
        private readonly IUsuarioRepository _usuarioRepository;
        private readonly LoginUsuario _loginUsuario;
        public LoginController(IUsuarioRepository usuarioRepository, LoginUsuario loginUsuario)
        {
            _usuarioRepository = usuarioRepository;
            _loginUsuario = loginUsuario;
        }

        [HttpGet]
        [Route("~/Admin")]
        [Route("~/Admin/Login")]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(LoginViewModel usuario)
        {
            Usuario usuarioDB = _usuarioRepository.Login(usuario.LoginName, usuario.Password);

            if (usuarioDB != null)
            {
                _loginUsuario.Login(usuarioDB);
                return RedirectToAction("Index", "Dashboard", new { area = "Admin" });
            }
            ViewData["MSG_E"] = "Usuário não localizado";
            return View(usuario);
        }

        public IActionResult Logout()
        {
            _loginUsuario.Logout();
            return RedirectToAction(nameof(Login));
        }

        [HttpGet]
        [ValidateHttpReferer]
        public IActionResult RecuperarSenha()
        {
            return View();
        }

        [HttpPost]
        public IActionResult RecuperarSenha(string email)
        {
            var usuario = _usuarioRepository.ObterUsuarioPorEmail(email);
            if (usuario != null)
            {
                usuario.Senha = Util.GetUniqueKey(8);
                _usuarioRepository.Atualizar(usuario);
                TempData["MSG_S"] = "Nova senha enviada para o e-mail: " + email;
                return RedirectToAction(nameof(Login));
                //TODO - Criar rotina para enviar e-mail com a senha do fulano
            }

            TempData["MSG_E"] = "Usuário não cadastrado, verifique o e-mail informado.";
            return View();
        }



    }
}
