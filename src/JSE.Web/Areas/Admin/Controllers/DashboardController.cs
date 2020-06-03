using JSE.Web.Extensions.Filtro;
using JSE.Web.Extensions.Login;
using JSE.Web.Models;
using JSE.Web.Repositories.Intefarces;
using Microsoft.AspNetCore.Mvc;

namespace JSE.Web.Areas.Admin.Controllers
{
    //TODO - Configurar paginas de erro
    //TODO - configurar a pagina incial para iniciar no Dashboard, hoje esta iniciando na pagina de serviço
    [Area("Admin")]
    //[UsuarioAutorizacao] - Validacao direto nas actions 
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

        [UsuarioAutorizacao] //Verificar se usuario esta logado para acessar o controller
        //[Route("~/Dashboard/Index")]
        public IActionResult Index()
        {
            return View();
        }


        [UsuarioAutorizacao] //Verificar se usuario esta logado para acessar o controller
        public IActionResult Contato()
        {
            return RedirectToAction(nameof(Index), "Contato", new { area = "Admin" });
        }

        [UsuarioAutorizacao] //Verificar se usuario esta logado para acessar o controller
        public IActionResult Servico()
        {
            return RedirectToAction(nameof(Index), "Servico", new { area = "Admin" });
        }

                
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        //TODO - Validar token 
        //public IActionResult Login([FromForm]Usuario usuario)
        public IActionResult Login(Usuario usuario)
        {
            Usuario usuarioDB = _usuarioRepository.Login(usuario.Email, usuario.Senha);

            if (usuarioDB != null)
            {
                _loginUsuario.Login(usuarioDB);
                return RedirectToAction(nameof(Index));
            }
            ViewData["MSG_E"] = "Usuário não localizado";
            return View(usuario);
        }


        [HttpPost]
        [UsuarioAutorizacao] //Verificar se usuario esta logado para acessar o controller
        //TODO - Validar token 
        public IActionResult RecuperarSenha(string email)
        {
            return RedirectToAction(nameof(Index), "Servico", new { area = "Admin" });
        }


        [UsuarioAutorizacao]
        public IActionResult Logout()
        {
            _loginUsuario.Logout();
            return RedirectToAction(nameof(Login));
        }


    }
}