using cloudscribe.Pagination.Models;
using JSE.Web.Extensions.Filtro;
using JSE.Web.Extensions.Lang;
using JSE.Web.Models;
using JSE.Web.Repositories.Intefarces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace JSE.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    [UsuarioAutorizacao]
    [Route("{area:exists}/{controller=Servico}/{action=Index}")]
    public class FaqsController : Controller
    {
        private readonly IFaqsRepository _faqsRepository;

        public FaqsController(IFaqsRepository faqsRepository)
        {
            _faqsRepository = faqsRepository;
        }

        // GET: Admin/Faqs
        [Route("~/Admin/Faqs")]
        public ViewResult Index(int pageNumber = 1, int pageSize = 10)
        {
            int excludeRecords = (pageNumber * pageSize) - pageSize;
            IQueryable<Faqs> categorias = _faqsRepository.ObterTodosFaqsPaginados(excludeRecords, pageNumber, pageSize);

            var result = new PagedResult<Faqs>
            {
                Data = categorias.AsNoTracking().ToList(),
                TotalItems = _faqsRepository.ObterTodasFaqs().Count(),
                PageNumber = pageNumber,
                PageSize = pageSize
            };

            return View(result);
        }

        public IActionResult AddOrEdit(int id = 0)
        {
            if (id == 0)
            {
                return View(new Faqs());
            }
            return View(_faqsRepository.ObterFaq(id));
        }


        [HttpPost]
        public IActionResult AddOrEdit([FromForm] Faqs Faqs)
        {
            if (ModelState.IsValid)
            {
                if (Faqs.Id == 0)
                {
                    _faqsRepository.Cadastrar(Faqs);
                }
                else
                {
                    _faqsRepository.Atualizar(Faqs);
                }

                TempData["MSG_S"] = Mensagem.MSG_S001;
                return RedirectToAction(nameof(Index));
            }
            return View(Faqs);
        }


        [ValidateHttpReferer]
        public IActionResult Delete(int id)
        {
            var categoria = _faqsRepository.ObterFaq(id);
            if (categoria != null)
            {
                _faqsRepository.Excluir(id);
                TempData["MSG_S"] = Mensagem.MSG_S002;
                return RedirectToAction(nameof(Index));
            }
            return RedirectToAction(nameof(Index));

        }


    }
}
