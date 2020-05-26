using cloudscribe.Pagination.Models;
using JSE.Web.Areas.Admin.ViewModel;
using JSE.Web.Data;
using JSE.Web.Extensions;
using JSE.Web.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace JSE.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("{area:exists}/{controller=Galeria}/{action=Index}")]
    [Route("{area:exists}/{controller=Galeria}/{action=Index}/{id?}")]
    public class GaleriaController : Controller
    {
        private readonly JSEContext _context;
        private readonly IWebHostEnvironment _env;

        public GaleriaController(JSEContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }

        public ViewResult Index(int pageNumber = 1, int pageSize = 10)
        {
            int excludeRecords = (pageNumber * pageSize) - pageSize;
            var galerias = _context.Galerias.OrderBy(g => g.GaleriaId).ThenBy(g => g.ServicoId)
                .Skip(excludeRecords)
                .Take(pageSize);

            var totalItems = _context.Galerias.Count();

            IList<GaleriaViewModel> listaGaleriaViewModel = new List<GaleriaViewModel>();

            foreach (var item in galerias)
            {
                GaleriaViewModel galViewModel = new GaleriaViewModel();
                galViewModel.GaleriaId = item.GaleriaId;
                galViewModel.ServicoId = item.ServicoId;
                galViewModel.NomeCliente = item.NomeCliente;
                galViewModel.DataCadastro = item.DataCadastro;
                galViewModel.Exibir = item.Exibir;
                galViewModel.NomeServico = _context.Servicos.Where(s => s.ServicoId == item.ServicoId).Select(s => s.NomeServico).Single();
                listaGaleriaViewModel.Add(galViewModel);
            }

            var result = new PagedResult<GaleriaViewModel>
            {
                Data = listaGaleriaViewModel.OrderBy(g => g.GaleriaId).ThenBy(g => g.NomeServico).ThenBy(g => g.NomeCliente).ToList(),
                //Data = galerias.AsNoTracking().ToList(),
                TotalItems = totalItems,
                PageNumber = pageNumber,
                PageSize = pageSize
            };

            return View(result);

        }

        public IActionResult AddOrEdit(int id = 0)
        {
            ViewBag.Servicos = _context.Servicos.OrderBy(s => s.NomeServico).ToList();
            if (id == 0)
            {
                return View(new Galeria());
            }
            var galeriateste = _context.Galerias.Find(id);
            return View(_context.Galerias.Find(id));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddOrEdit([FromForm] List<IFormFile> files, Galeria galeria)
        {
            if (ModelState.IsValid)
            {
                ViewBag.Servicos = _context.Servicos.OrderBy(s => s.NomeServico).ToList();

                Random rand = new Random();
                var uploadPath = Path.Combine(_env.WebRootPath, "images\\uploads\\galeria\\");
                var fileName = Util.GenerateCoupon(10, rand);
                bool atualizaImagem = false;

                try
                {
                    foreach (var file in files)
                    {
                        if (file != null && file.Length > 0)
                        {
                            fileName += Path.GetExtension(file.FileName);
                            using (var s = new FileStream(Path.Combine(uploadPath, fileName), FileMode.Create))
                            {
                                await file.CopyToAsync(s);
                                atualizaImagem = true;
                            }
                        }
                    }

                    if (atualizaImagem)
                    {
                        if (System.IO.File.Exists(galeria.Imagem))
                        {
                            System.IO.File.Delete(galeria.Imagem);
                        }

                        galeria.Imagem = uploadPath + fileName;
                        galeria.NomeArquivo = fileName;
                    }

                    if (galeria.ServicoId == 0)
                    {
                        _context.Add(galeria);
                    }
                    else
                    {
                        _context.Update(galeria);
                    }
                    _context.SaveChanges();
                    return Redirect("~/Admin/Galeria");

                }
                catch (DataException)
                {
                    return RedirectToAction("~/Admin/Galeria/AddOrEdit", new { Servico = galeria, saveChangesError = true });
                }

            }
            else
            {
                return View(galeria);
            }

        }

        public IActionResult Delete(int? id)
        {
            var galeria = _context.Galerias.Find(id);
            if (galeria != null)
            {
                var imagem = galeria.Imagem;
                _context.Galerias.Remove(galeria);
                _context.SaveChanges();

                if (System.IO.File.Exists(imagem))
                {
                    System.IO.File.Delete(imagem);
                }
                return Redirect("~/Admin/Galeria");
            }
            return RedirectToAction("Index");
        }

        public List<Servico> ListaServicos()
        {
            try
            {
                var lista = _context.Servicos.OrderBy(s => s.ServicoId)
                .ThenBy(s => s.NomeServico)
                .ToList();
                return lista;

            }
            catch (System.Exception)
            {
                return null;
            }
        }

    }
}
