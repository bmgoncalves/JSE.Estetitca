using cloudscribe.Pagination.Models;
using JSE.Web.Data;
using JSE.Web.Models;
using JSE.Web.Repositories;
using JSE.Web.Repositories.Intefarces;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace JSE.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("{area:exists}/{controller=Depoimento}/{action=Index}/{id?}")]
    public class DepoimentoController : Controller
    {
        private readonly IWebHostEnvironment _env;
        private readonly IDepoimentoRepository _depoimentoRepository;

        public DepoimentoController(IWebHostEnvironment env, IDepoimentoRepository depoimentoRepository)
        {
            //_context = context;
            _env = env;
            _depoimentoRepository = depoimentoRepository;
        }


        public ViewResult Index(int pageNumber = 1, int pageSize = 15)
        {
            int excludeRecords = (pageNumber * pageSize) - pageSize;
            var depoimentos = _depoimentoRepository.GetDepoimentosPendente(excludeRecords, pageNumber, pageSize);

            var result = new PagedResult<Depoimento>
            {
                Data = depoimentos.AsNoTracking().ToList(),
                TotalItems = _depoimentoRepository.ListaDepoimentosPendentes().Count(),
                PageNumber = pageNumber,
                PageSize = pageSize
            };

            return View(result);
        }

        public IActionResult Aprovar(int id = 0)
        {
            return View(_depoimentoRepository.GetDepoimento(id));
        }

        [HttpPost]
        public IActionResult Aprovar(int id, [FromForm] Depoimento depoimento)
        {
            if (ModelState.IsValid)
            {
                _depoimentoRepository.AprovarDepoimento(depoimento);
                return Redirect("~/Admin/Depoimento");
                //return RedirectToAction(nameof(Index), "Contato", new { area = "Admin" });
            }

            return View(depoimento);
        }

        public IActionResult Delete(int id)
        {
            var depoimento = _depoimentoRepository.GetDepoimento(id);

            var arquivo = Path.Combine(_env.WebRootPath, "images\\uploads\\Depoimentos\\" + depoimento.NomeArquivo);
            if (depoimento != null)
            {
                _depoimentoRepository.Excluir(depoimento.Id);
                if (System.IO.File.Exists(arquivo))
                {
                    System.IO.File.Delete(arquivo);
                }
            }
            return Redirect("~/Admin/Depoimento");


        }

    }
}
