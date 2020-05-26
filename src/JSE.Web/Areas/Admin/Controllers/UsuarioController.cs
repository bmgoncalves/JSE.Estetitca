using JSE.Web.Extensions.Lang;
using JSE.Web.Models;
using JSE.Web.Repositories.Intefarces;
using Microsoft.AspNetCore.Mvc;
using X.PagedList;

namespace JSE.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("{area:exists}/{controller=Usuario}/{action=Index}")]
    [Route("{area:exists}/{controller=Usuario}/{action=Index}/{id?}")]
    public class UsuarioController : Controller
    {
        private readonly IUsuarioRepository _usuarioRepository;

        public UsuarioController(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }

        public IActionResult Index(int? pagina, string pesquisa)
        {
            IPagedList<Usuario> usuarios = _usuarioRepository.ObterTodosUsuarios(pagina, pesquisa);
            return View(usuarios);
        }


        public IActionResult AddOrEdit(int id)
        {
            var usuario = _usuarioRepository.ObterUsuario(id);
            if (usuario != null)
            {
                return View(usuario);
            }
            return View();
        }

        [HttpPost]
        public IActionResult AddOrEdit([FromForm] Usuario usuario)
        {
            if (ModelState.IsValid)
            {
                if (usuario.UsuarioId == 0)
                {
                    _usuarioRepository.Cadastrar(usuario);
                }
                else
                {
                    _usuarioRepository.Atualizar(usuario);
                }
                TempData["MSG_S"] = Mensagem.MSG_S001;
                //return RedirectToAction(nameof(Index), nameof(UsuarioController));
                return Redirect("~/Admin/Usuario");
            }
            return View();
        }


        public IActionResult Delete(int id)
        {
            _usuarioRepository.Excluir(id);
            return Redirect("~/Admin/Usuario");
        }

        public IActionResult AtivarDesativar(int id)
        {
            _usuarioRepository.AtivarDesativar(id);
            return Redirect("~/Admin/Usuario");
        }








    }
}