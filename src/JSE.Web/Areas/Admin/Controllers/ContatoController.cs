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
    public class ContatoController : Controller
    {
        private readonly JSEContext _context;

        public ContatoController(JSEContext context)
        {
            _context = context;
        }

        // GET: Admin/Contato
        public async Task<IActionResult> Index()
        {
            return View(await _context.Contatos.ToListAsync());
        }

        // GET: Admin/Contato/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/Contato/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ContatoId,Nome,Mensagem,Email,Telefone,ContatoWhatsapp,DataHora,Pendente")] Contato contato)
        {
            if (ModelState.IsValid)
            {
                _context.Add(contato);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(contato);
        }

        // GET: Admin/Contato/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var contato = await _context.Contatos
                .FirstOrDefaultAsync(m => m.ContatoId == id);
            if (contato == null)
            {
                return NotFound();
            }

            return View(contato);
        }

        
    }
}
