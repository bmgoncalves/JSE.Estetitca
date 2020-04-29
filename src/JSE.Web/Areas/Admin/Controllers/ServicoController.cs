using cloudscribe.Pagination.Models;
using JSE.Web.Data;
using JSE.Web.Extensions;
using JSE.Web.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace JSE.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ServicoController : Controller
    {
        private readonly JSEContext _context;
        private readonly IWebHostEnvironment _env;

        public ServicoController(JSEContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
            
        }

        // GET: Admin/Servico
        [Route("{area:exists}/{controller=Servico}/{action=Index}/{id?}")]
        public ViewResult Index(int pageNumber = 1, int pageSize = 10)
        {

            int excludeRecords = (pageNumber * pageSize) - pageSize;
            var servicos = _context.Servicos.OrderBy(s => s.NomeServico).ThenBy(s => s.Id)
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
        [Route("{area:exists}/{controller=Servico}/{action=Index}/{id?}")]
        public async Task<IActionResult> AddOrEdit([FromForm] List<IFormFile> files, [Bind("Id,NomeServico,Descricao,Duracao,Imagem,NomeArquivo,ExibeIndex")] Servico servico)
        {
            if (ModelState.IsValid)
            {
                Random rand = new Random();
                var uploadPath = Path.Combine(_env.WebRootPath, "images\\uploads\\servicos\\");
                var fileName = Util.GenerateCoupon(10, rand);
                var nomeArquivo = "";
                bool atualizaImagem = false;

                try
                {

                    foreach (var file in files)
                    {
                        if (file != null && file.Length > 0)
                        {
                            fileName += Path.GetExtension(file.FileName);

                            using (var s = new FileStream(Path.Combine(uploadPath, fileName),
                                                                        FileMode.Create))
                            {
                                await file.CopyToAsync(s);
                                nomeArquivo = fileName;
                                atualizaImagem = true;
                            }
                        }
                    }

                    if (atualizaImagem)
                    {
                        if (System.IO.File.Exists(servico.Imagem))
                        {
                            System.IO.File.Delete(servico.Imagem);
                        }

                        servico.Imagem = uploadPath + fileName;
                        servico.NomeArquivo = fileName;
                    }

                    if (servico.Id == 0)
                    {
                        _context.Add(servico);
                    }
                    else
                    {
                        _context.Update(servico);
                    }


                    _context.SaveChanges();
                    return Redirect("~/Admin/Servico");

                }
                catch (DataException)
                {
                    return RedirectToAction("~/Admin/Servico/AddOrEdit", new { Servico = servico, saveChangesError = true });
                }

            }
            else
            {
                var list = new List<string>();
                foreach (var modelStateVal in ViewData.ModelState.Values)
                {
                    list.AddRange(modelStateVal.Errors.Select(error => error.ErrorMessage));
                }
                return Json(new { status = "error", errors = list });
            }

        }

        // GET: Admin/Servico/Delete/5
        public IActionResult Delete(int? id)
        {
            var servico = _context.Servicos.Find(id);
            if (servico != null)
            {
                var imagem = servico.Imagem;
                                
                _context.Servicos.Remove(servico);
                _context.SaveChanges();

                if (System.IO.File.Exists(imagem))
                {
                    System.IO.File.Delete(imagem);
                }

                return Redirect("~/Admin/Servico");

            }
            return RedirectToAction("Index");
        }
       
    }
}
