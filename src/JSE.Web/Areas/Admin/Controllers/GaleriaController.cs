using JSE.Web.Data;
using JSE.Web.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace JSE.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class GaleriaController : Controller
    {
        private readonly JSEContext _context;

        public GaleriaController(JSEContext context)
        {
            _context = context;
        }

        // GET: Admin/Galeria
        public async Task<IActionResult> Index()
        {
            return View(await _context.Galerias.ToListAsync());
        }

        // GET: Admin/Galeria/Create
        public IActionResult AddOrEdit()
        {
            return View();
        }

        // POST: Admin/Galeria/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddOrEdit([Bind("GaleriaId,ServicoId,Imagem,NomeArquivo")] Galeria galeria)
        {
            if (ModelState.IsValid)
            {
                _context.Add(galeria);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(galeria);
        }

        // GET: Admin/Galeria/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var galeria = await _context.Galerias
                .FirstOrDefaultAsync(m => m.GaleriaId == id);
            if (galeria == null)
            {
                return NotFound();
            }

            return View(galeria);
        }
        
    }
}
