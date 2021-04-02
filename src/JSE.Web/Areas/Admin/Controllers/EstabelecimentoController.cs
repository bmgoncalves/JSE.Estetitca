using JSE.Web.Extensions.Filtro;
using JSE.Web.Models;
using JSE.Web.Repositories.Intefarces;
using Microsoft.AspNetCore.Mvc;

namespace JSE.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    [UsuarioAutorizacao]
    [Route("{area:exists}/{controller=Estabelecimento}/{action=Index}")]
    [Route("{area:exists}/{controller=Estabelecimento}/{action=Index}/{id?}")]
    public class EstabelecimentoController : Controller
    {
        private readonly IEstabelecimentoRepository _estabelecimentoRepository;
        public EstabelecimentoController(IEstabelecimentoRepository estabelecimentoRepository)
        {
            _estabelecimentoRepository = estabelecimentoRepository;
        }

        [Route("~/Admin/Estabelecimento")]
        public IActionResult Index()
        {
            return View(_estabelecimentoRepository.ObterTodosEstabelecimentos());
        }

        public IActionResult AddOrEdit(int id = 0)
        {
            if (id == 0)
            {
                return View(new Estabelecimento());
            }
            return View(_estabelecimentoRepository.ObterEstabelecimento(id));
        }

        [HttpPost]
        public IActionResult AddOrEdit([FromForm] Estabelecimento estabelecimento)
        {
            if (ModelState.IsValid)
            {
                if (estabelecimento.Id == 0)
                {
                    _estabelecimentoRepository.Cadastrar(estabelecimento);
                }
                else
                {
                    _estabelecimentoRepository.Atualizar(estabelecimento);
                }
                return RedirectToAction(nameof(Index));
            }
            return View(estabelecimento);
        }

        [ValidateHttpReferer]
        public IActionResult Delete(int id)
        {
            _estabelecimentoRepository.Excluir(id);
            return RedirectToAction("Index");
        }

    }
}
