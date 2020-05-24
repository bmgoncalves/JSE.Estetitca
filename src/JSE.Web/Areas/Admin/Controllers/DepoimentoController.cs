using cloudscribe.Pagination.Models;
using JSE.Web.Data;
using JSE.Web.Models;
using JSE.Web.Repositories;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace JSE.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class DepoimentoController : Controller
    {
        private readonly JSEContext _context;

        private readonly IWebHostEnvironment _env;
        private readonly DepoimentoRepository _depoimentoRepository;

        public DepoimentoController(JSEContext context, IWebHostEnvironment env, DepoimentoRepository depoimentoRepository)
        {
            _context = context;
            _env = env;
            _depoimentoRepository = depoimentoRepository;

        }

        // GET: Admin/Servico
        [Route("{area:exists}/{controller=Depoimento}/{action=Index}/{id?}")]
        public ViewResult Index(int pageNumber = 1, int pageSize = 15)
        {
            int excludeRecords = (pageNumber * pageSize) - pageSize;
            var depoimentos = _context.Depoimentos.Where(d => d.Aprovado == false).OrderBy(d => d.DataCriacao).ThenBy(d => d.NomeCliente)
                .Skip(excludeRecords)
                .Take(pageSize);

            var result = new PagedResult<Depoimento>
            {
                Data = depoimentos.AsNoTracking().ToList(),
                TotalItems = _context.Servicos.Count(),
                PageNumber = pageNumber,
                PageSize = pageSize
            };

            return View(result);
        }

        public IActionResult Aprovar(int id=0)
        {
            return View(_depoimentoRepository.GetDepoimento(id));
        }

        [HttpPost]
        [Route("{area:exists}/{controller=Depoimento}/{action=Index}/{id?}")]
        public IActionResult Aprovar(int id, [FromForm] Depoimento depoimento)
        {
            if (ModelState.IsValid)
            {
                _depoimentoRepository.AprovarDepoimento(depoimento);
                return RedirectToAction(nameof(Index));
            }
            return View(depoimento);
        }

        public IActionResult Delete(int? id)
        {
            var depoimento = _context.Depoimentos.Find(id);
            var arquivo = Path.Combine(_env.WebRootPath, "images\\uploads\\Depoimentos\\" + depoimento.NomeArquivo);
            if (depoimento != null)
            {
                _depoimentoRepository.Excluir(depoimento.Id);
                if (System.IO.File.Exists(arquivo))
                {
                    System.IO.File.Delete(arquivo);
                }
            }
            return RedirectToAction(nameof(Index));

        }

    }
}
