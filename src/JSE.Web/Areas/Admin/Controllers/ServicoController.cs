using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using JSE.Web.Data;
using JSE.Web.Models;

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
        public async Task<IActionResult> Index()
        {
            return View(await _context.Servicos.ToListAsync());
        }


        // GET: Admin/Servico/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/Servico/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,NomeServico")] Servico servico)
        {
            if (ModelState.IsValid)
            {
                _context.Add(servico);
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
