﻿using cloudscribe.Pagination.Models;
using JSE.Web.Data;
using JSE.Web.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace JSE.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class DepoimentoController : Controller
    {
        private readonly JSEContext _context;

        public DepoimentoController(JSEContext context)
        {
            _context = context;
        }

        // GET: Admin/Servico
        [Route("{area:exists}/{controller=Depoimento}/{action=Index}/{id?}")]
        public ViewResult Index(int pageNumber = 1, int pageSize = 15)
        {

            int excludeRecords = (pageNumber * pageSize) - pageSize;
            var depoimentos = _context.Depoimentos.Where(d => d.Aprovado == false).OrderBy(d => d.DataCriacao).ThenBy(d => d.NomeCliente)
                .Skip(excludeRecords)
                .Take(pageSize);

            var result = new PagedResult<Depoimento>
            {
                Data = depoimentos.AsNoTracking().ToList(),
                TotalItems = _context.Servicos.Count(),
                PageNumber = pageNumber,
                PageSize = pageSize
            };

            return View(result);
        }


        // GET: Admin/Depoimento/Edit/5
        public async Task<IActionResult> Aprovar(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var depoimento = await _context.Depoimentos.FindAsync(id);
            if (depoimento == null)
            {
                return NotFound();
            }
            return View(depoimento);
        }

        // POST: Admin/Depoimento/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Aprovar(int id, [Bind("Id,Descricao,NomeCliente,TelefoneCelular,Email,Imagem,DataCriacao,Aprovado")] Depoimento depoimento)
        {
            if (id != depoimento.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(depoimento);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DepoimentoExists(depoimento.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(depoimento);
        }

        // GET: Admin/Depoimento/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var depoimento = await _context.Depoimentos
                .FirstOrDefaultAsync(m => m.Id == id);
            if (depoimento == null)
            {
                return NotFound();
            }

            return View(depoimento);
        }


        private bool DepoimentoExists(int id)
        {
            return _context.Depoimentos.Any(e => e.Id == id);
        }
    }
}
