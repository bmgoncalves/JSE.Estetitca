using JSE.Web.Data;
using JSE.Web.Extensions.Filtro;
using JSE.Web.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace JSE.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("{area:exists}/{controller=Estabelecimento}/{action=Index}")]
    [Route("{area:exists}/{controller=Estabelecimento}/{action=Index}/{id?}")]
    public class EstabelecimentoController : Controller
    {
        private readonly JSEContext _context;
        //TODO - Criar repositorio do estabelecimento

        public EstabelecimentoController(JSEContext context)
        {
            _context = context;
        }

        [Route("~/Admin/Estabelecimento")]
        public IActionResult Index()
        {
            return View(_context.Estabelecimentos.ToList());
        }

        public IActionResult AddOrEdit(int id=0)
        {
            if (id == 0)
            {
                return View(new Estabelecimento());
            }
            return View(_context.Estabelecimentos.Find(id));
        }
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddOrEdit([FromForm]Estabelecimento estabelecimento)
        {
            if (ModelState.IsValid)
            {
                if (estabelecimento.Id == 0)
                {
                    _context.Add(estabelecimento);
                }
                else
                {
                    _context.Update(estabelecimento);
                }
                _context.SaveChanges();
                return Redirect("~/Admin/Estabelecimento");

            }
            return View(estabelecimento);
        }

        [ValidateHttpReferer]
        public IActionResult Delete(int? id)
        {
            var estabel = _context.Estabelecimentos.Find(id);
            if (estabel != null)
            {
                _context.Estabelecimentos.Remove(estabel);
                _context.SaveChanges();
                return Redirect("~/Admin/Estabelecimento");

            }
            return RedirectToAction("Index");
        }

    }
}
