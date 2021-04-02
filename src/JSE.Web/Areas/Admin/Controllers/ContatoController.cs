using cloudscribe.Pagination.Models;
using JSE.Web.Extensions.Filtro;
using JSE.Web.Models;
using JSE.Web.Repositories.Intefarces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
// ReSharper disable All

namespace JSE.Web.Areas.Admin.Controllers
{
    [Area(areaName: "Admin")]
    [UsuarioAutorizacao]
    [Route(template: @"{area:exists}/{controller=Contato}/{action=Index}")]
    [Route(template: "{area:exists}/{controller=Contato}/{action=Index}/{id?}")]

    //TODO - Melhorar tela inicial dos contatos
    //TODO - Melhorar tela inicial dos depoimentos
    public class ContatoController : Controller
    {
        private readonly IContatoRepository _contatoRepository;
        public ContatoController(IContatoRepository contatoRepository)
        {
            _contatoRepository = contatoRepository;
        }

        // ReSharper disable once StringLiteralTypo
        [Route(template: "~/Admin/Contato")]
        public ViewResult Index(int pageNumber = 1, int pageSize = 10)
        {
            int excludeRecords = (pageNumber * pageSize) - pageSize;
            var contatos = _contatoRepository.ObterTodosContatosPaginados(excludeRecords: excludeRecords,
                pageNumber: pageNumber, pageSize: pageSize);

            var result = new PagedResult<Contato>
            {
                Data = contatos.AsNoTracking().ToList(),
                TotalItems = _contatoRepository.ObterTodosContatosPendentes().Count(),
                PageNumber = pageNumber,
                PageSize = pageSize
            };
            return View(model: result);
        }

        // GET: Admin/Contato/Create
        public IActionResult AddOrEdit(int id = 0)
        {
            if (id == 0)
            {
                return View(model: new Contato());
            }
            return View(model: _contatoRepository.ObterContato(id: id));
        }

        [HttpPost]
        public IActionResult AddOrEdit([FromForm] Contato contato)
        {
            if (ModelState.IsValid)
            {
                _contatoRepository.AprovarReprovar(contato: contato);
                return RedirectToAction(actionName: nameof(Index));
            }
            return View(model: contato);
        }


        [ValidateHttpReferer]
        public IActionResult Delete(int id)
        {
            _contatoRepository.Excluir(id: id);
            return RedirectToAction(actionName: nameof(Index));
        }
    }
}
