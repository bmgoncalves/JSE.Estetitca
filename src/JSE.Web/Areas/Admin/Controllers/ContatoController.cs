using JSE.Web.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace JSE.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ContatoController : Controller
    {
        private readonly JSEContext _context;

        public ContatoController(JSEContext context)
        {
            _context = context;
        }

        // GET: Admin/Contato
        public IActionResult Index()
        {
            //return View(await _context.Contatos.ToListAsync());
            return View();
        }

        // GET: Admin/Contato/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var contato = await _context.Contatos.FirstOrDefaultAsync(m => m.Id == id);
            if (contato == null)
            {
                return NotFound();
            }

            return View(contato);
        }


    }
}
