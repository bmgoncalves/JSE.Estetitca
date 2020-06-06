using JSE.Web.Extensions;
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
        private readonly IContatoRepository _contatoRepository;
        private readonly IDepoimentoRepository _depoimentoRepository;

        public DashboardController(IUsuarioRepository usuarioRepository, IContatoRepository contatoRepository, IDepoimentoRepository depoimentoRepository,LoginUsuario loginUsuario)
        {
            _usuarioRepository = usuarioRepository;
            _loginUsuario = loginUsuario;
            _contatoRepository = contatoRepository;
            _depoimentoRepository = depoimentoRepository;
        }

        [UsuarioAutorizacao] //Verificar se usuario esta logado para acessar o controller
        [Route("~/Admin/Dashboard/Index")]
        public IActionResult Index()
        {
            var usuario = _loginUsuario.GetUsuario();
            ViewBag.Contatos = _contatoRepository.ObterTodosContatosPaginados(0,1,5);
            ViewBag.Depoimentos = _depoimentoRepository.GetDepoimentosPendente(0, 1, 5);

            if (usuario != null)
            {
                ViewBag.Usuario = usuario.Nome;
            }
            else
            {
                ViewBag.Usuario = "Usuário não conectado";
            }

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
        
        public IActionResult Login(Usuario usuario)
        {
            Usuario usuarioDB = _usuarioRepository.Login(usuario.Email, usuario.Senha);

            if (usuarioDB != null)
            {
                _loginUsuario.Login(usuarioDB);
                return RedirectToAction("Index", "Dashboard");
            }
            ViewData["MSG_E"] = "Usuário não localizado";
            return View(usuario);
        }

        [UsuarioAutorizacao]
        public IActionResult Logout()
        {
            _loginUsuario.Logout();
            return RedirectToAction(nameof(Login));
        }

        [ValidateHttpReferer]
        public IActionResult RecuperaSenha()
        {
            return View();
        }

        [HttpPost]
        public IActionResult RecuperaSenha(string email)
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