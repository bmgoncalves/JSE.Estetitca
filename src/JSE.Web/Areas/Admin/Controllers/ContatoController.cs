using cloudscribe.Pagination.Models;
using JSE.Web.Data;
using JSE.Web.Extensions.Filtro;
using JSE.Web.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace JSE.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    //[Route("{area:exists}/{controller=Contato}/{action=Index}")]
    //[Route("{area:exists}/{controller=Contato}/{action=Index}/{id?}")]
    public class ContatoController : Controller
    {
        private readonly JSEContext _context;

        public ContatoController(JSEContext context)
        {
            _context = context;
        }

        public ViewResult Index(int pageNumber = 1, int pageSize = 10)
        {
            int excludeRecords = (pageNumber * pageSize) - pageSize;
            var contatos = _context.Contatos.Where(c => c.Pendente == true)
                                            .OrderBy(c => c.Nome)
                                            .ThenBy(c => c.ContatoId)
                                            .ThenBy(c => c.DataHora)
                                            .Skip(excludeRecords)
                                            .Take(pageSize);

            var result = new PagedResult<Contato>
            {
                Data = contatos.AsNoTracking().ToList(),
                TotalItems = _context.Contatos.Count(),
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
            return View(_context.Contatos.Find(id));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddOrEdit([FromForm] Contato contato)
        {
            if (ModelState.IsValid)
            {
                if (contato.ContatoId == 0)
                {
                    _context.Add(contato);
                }
                else
                {
                    _context.Update(contato);
                }

                _context.SaveChanges();
                return Redirect("~/Admin/Contato");
            }
            return View(contato);
        }


        [ValidateHttpReferer]
        public IActionResult Delete(int? id)
        {
            var contato = _context.Contatos.Find(id);
            if (contato != null)
            {
                _context.Contatos.Remove(contato);
                _context.SaveChanges();
                return Redirect("~/Admin/Contato");
            }
            return RedirectToAction("Index");
        }
    }
}
