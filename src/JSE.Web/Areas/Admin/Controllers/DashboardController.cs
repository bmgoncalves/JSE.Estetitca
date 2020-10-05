using JSE.Web.Extensions;
using JSE.Web.Extensions.Filtro;
using JSE.Web.Extensions.Login;
using JSE.Web.Models;
using JSE.Web.Repositories.Intefarces;
using Microsoft.AspNetCore.Mvc;

namespace JSE.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    [UsuarioAutorizacao]
    [Route("{area:exists}/{controller=Dashboard}/{action=Index}/{id?}")]
    public class DashboardController : Controller
    {
        
        private readonly IContatoRepository _contatoRepository;
        private readonly IDepoimentoRepository _depoimentoRepository;

        public DashboardController(IUsuarioRepository usuarioRepository, IContatoRepository contatoRepository, IDepoimentoRepository depoimentoRepository,LoginUsuario loginUsuario)
        {
            _contatoRepository = contatoRepository;
            _depoimentoRepository = depoimentoRepository;
        }

        [Route("~/Admin/Dashboard/Index")]
        public IActionResult Index()
        {
            ViewBag.Contatos = _contatoRepository.ObterTodosContatosPaginados(0,1,5);
            ViewBag.Depoimentos = _depoimentoRepository.GetDepoimentosPendente(0, 1, 5);

            return View();
        }

        public IActionResult Contato()
        {
            return RedirectToAction(nameof(Index), "Contato", new { area = "Admin" });
        }

        public IActionResult Servico()
        {
            return RedirectToAction(nameof(Index), "Servico", new { area = "Admin" });
        }
    }
}