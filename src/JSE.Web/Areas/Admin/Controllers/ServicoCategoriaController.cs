using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using JSE.Web.Data;
using JSE.Web.Models;
using cloudscribe.Pagination.Models;

namespace JSE.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ServicoCategoriaController : Controller
    {
        private readonly JSEContext _context;

        public ServicoCategoriaController(JSEContext context)
        {
            _context = context;
        }

        // GET: Admin/ServicoCategoria
        [Route("{area:exists}/{controller=ServicoCategoria}/{action=Index}/{id?}")]
        public ViewResult Index(int pageNumber = 1, int pageSize = 10)
        {
            int excludeRecords = (pageNumber * pageSize) - pageSize;
            var categorias = _context.ServicoCategorias.OrderBy(c => c.Categoria).ThenBy(c => c.CategoriaId)
                .Skip(excludeRecords)
                .Take(pageSize);

            var result = new PagedResult<ServicoCategoria>
            {
                Data = categorias.AsNoTracking().ToList(),
                TotalItems = _context.ServicoCategorias.Count(),
                PageNumber = pageNumber,
                PageSize = pageSize
            };

            return View(result);
        }

        [Route("{area:exists}/{controller=ServicoCategoria}/{action=Index}/{id?}")]
        public IActionResult AddOrEdit(int id=0)
        {
            if (id == 0)
            {
                return View(new ServicoCategoria());
            }
            return View(_context.ServicoCategorias.Find(id));
        }

        
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("{area:exists}/{controller=ServicoCategoria}/{action=Index}/{id?}")]
        public async Task<IActionResult> AddOrEdit([Bind("Id,Categoria,Ativo")] ServicoCategoria servicoCategoria)
        {
            if (ModelState.IsValid)
            {
                if (servicoCategoria.CategoriaId == 0)
                {
                    _context.Add(servicoCategoria);
                }
                else
                {
                    _context.Update(servicoCategoria);
                }
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(servicoCategoria);
        }


        public IActionResult Delete(int? id)
        {
            var categoria = _context.ServicoCategorias.Find(id);

            //Criar regra para não permitir exclusão com serviço vinculado
            if (categoria != null)
            {
                _context.ServicoCategorias.Remove(categoria);
                _context.SaveChanges();
                return Redirect("~/Admin/ServicoCategoria");
            }
            return RedirectToAction("Index");
        }

        

    }
}
