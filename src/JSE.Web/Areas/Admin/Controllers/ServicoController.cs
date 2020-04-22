using cloudscribe.Pagination.Models;
using JSE.Web.Data;
using JSE.Web.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace JSE.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ServicoController : Controller
    {
        private readonly JSEContext _context;

        public ServicoController(JSEContext context)
        {
            _context = context;
        }

        // GET: Admin/Servico
        public ViewResult Index(int pageNumber = 1, int pageSize = 5)
        {

            int excludeRecords = (pageNumber * pageSize) - pageSize;
            var servicos = _context.Servicos.OrderBy(s => s.Id)
                .Skip(excludeRecords)
                .Take(pageSize);


            var result = new PagedResult<Servico>
            {
                Data = servicos.AsNoTracking().ToList(),
                TotalItems = _context.Servicos.Count(),
                PageNumber = pageNumber,
                PageSize = pageSize
            };

            return View(result);
        }

        // GET: Admin/Servico/Create
        //[Route("Admin/Servico/AddOrEdit/{id?}")]
        public IActionResult AddOrEdit(int id = 0)
        {
            if (id == 0)
            {
                return View(new Servico());
            }
            return View(_context.Servicos.Find(id));
        }

        // POST: Admin/Servico/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddOrEdit([Bind("Id,NomeServico,Descricao,Duracao")] Servico servico)
        {
            if (ModelState.IsValid)
            {
                if (servico.Id == 0)
                {
                    _context.Add(servico);
                }
                else
                {
                    _context.Update(servico);
                }
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(servico);
        }

        // GET: Admin/Servico/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var servico = await _context.Servicos
                .FirstOrDefaultAsync(m => m.Id == id);
            if (servico == null)
            {
                return NotFound();
            }

            return View(servico);
        }
       
    }
}
