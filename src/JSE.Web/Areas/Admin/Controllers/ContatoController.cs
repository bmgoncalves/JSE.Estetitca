using cloudscribe.Pagination.Models;
using JSE.Web.Data;
using JSE.Web.Extensions.Filtro;
using JSE.Web.Models;
using JSE.Web.Repositories.Intefarces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace JSE.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    [UsuarioAutorizacao]
    [Route("{area:exists}/{controller=Contato}/{action=Index}")]
    [Route("{area:exists}/{controller=Contato}/{action=Index}/{id?}")]

    //TODO - Melhorar tela inicial dos contatos
    //TODO - Melhorar tela inicial dos depoimentos
    public class ContatoController : Controller
    {
        private readonly IContatoRepository _contatoRepository;
        public ContatoController(IContatoRepository contatoRepository)
        {
            _contatoRepository = contatoRepository;
        }

        [Route("~/Admin/Contato")]
        public ViewResult Index(int pageNumber = 1, int pageSize = 10)
        {
            int excludeRecords = (pageNumber * pageSize) - pageSize;
            var contatos = _contatoRepository.ObterTodosContatosPaginados(excludeRecords, pageNumber, pageSize);

            var result = new PagedResult<Contato>
            {
                Data = contatos.AsNoTracking().ToList(),
                TotalItems = _contatoRepository.ObterTodosContatosPendentes().Count(),
                PageNumber = pageNumber,
                PageSize = pageSize
            };
            return View(result);
        }

        // GET: Admin/Contato/Create
        public IActionResult AddOrEdit(int id = 0)
        {
            if (id == 0)
            {
                return View(new Contato());
            }
            return View(_contatoRepository.ObterContato(id));
        }

        [HttpPost]
        public IActionResult AddOrEdit([FromForm] Contato contato)
        {
            if (ModelState.IsValid)
            {
                _contatoRepository.AprovarReprovar(contato);
                return RedirectToAction(nameof(Index));
            }
            return View(contato);
        }


        [ValidateHttpReferer]
        public IActionResult Delete(int id)
        {
            _contatoRepository.Excluir(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
