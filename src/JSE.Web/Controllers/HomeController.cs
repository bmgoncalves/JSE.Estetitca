using JSE.Web.Data;
using JSE.Web.Models;
using JSE.Web.ViewModel;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace JSE.Web.Controllers
{
    public class HomeController : Controller
    {
        public JSEContext _context { get; set; }
        private readonly IWebHostEnvironment _env;

        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, JSEContext contexto, IWebHostEnvironment env)
        {
            _logger = logger;
            _context = contexto;
            _env = env;
        }

        public IActionResult Index()
        {
            IndexViewModel idx = new IndexViewModel()
            {
                Estabel = _context.Estabelecimentos.Where(e => e.Ativo == true).FirstOrDefault()
            };

            return View(idx);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        /// <summary>
        /// Registrar contato do cliente na pagina inicial
        /// </summary>
        /// <param name="contato"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult RegistraContato(Contato contato)
        {
            if (contato != null)
            {
                try
                {
                    _context.Contatos.Add(contato);
                    _context.SaveChanges();
                    return Json("OK");
                }
                catch (Exception ex)
                {
                    TempData["alertType"] = "alert-success";
                    TempData["Message"] = ex.Message;

                    return Json(ex.Message);
                }
            }
            else
            {
                return Json("Contato inválido, verifique as informações preenchidas");
            }
        }


        public IActionResult Estabelecimento()
        {
            var estabelecimento = _context.Estabelecimentos.Where(e => e.Ativo == true);
            return View(estabelecimento);
        }

        [HttpPost]
        public async Task<IActionResult> DepoimentoAntigoFuncionando(Depoimento depoimento, IEnumerable<IFormFile> files)
        {

            if (ModelState.IsValid)
            {
                var uploads = Path.Combine(_env.WebRootPath, "images");
                var usuario = depoimento.NomeCliente;
                var nomeArquivo = "";
                foreach (var file in files)
                {
                    if (file != null && file.Length > 0)
                    {
                        var fileName = Guid.NewGuid().ToString().Replace("-", "") +
                                        Path.GetExtension(file.FileName);
                        using (var s = new FileStream(Path.Combine(uploads, fileName),
                                                                    FileMode.Create))
                        {
                            await file.CopyToAsync(s);
                            nomeArquivo = fileName;
                        }
                    }
                }
                return Json(new { status = "success", message = "Depoimento enviado com sucesso" });
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

        [HttpPost]
        public async Task<IActionResult> Depoimento(Depoimento depoimento, IEnumerable<IFormFile> files)
        {

            if (ModelState.IsValid)
            {
                var uploads = Path.Combine(_env.WebRootPath, "images\\uploads\\depoimentos\\");
                var usuario = depoimento.NomeCliente;
                var nomeArquivo = "";

                try
                {
                    _context.Depoimentos.Add(depoimento);
                    _context.SaveChanges();

                    foreach (var file in files)
                    {
                        if (file != null && file.Length > 0)
                        {
                            var fileName = Guid.NewGuid().ToString().Replace("-", "") +
                                            Path.GetExtension(file.FileName);
                            using (var s = new FileStream(Path.Combine(uploads, fileName),
                                                                        FileMode.Create))
                            {
                                await file.CopyToAsync(s);
                                nomeArquivo = fileName;
                            }
                        }
                    }
                    return Json(new { status = "success", message = "Depoimento enviado com sucesso" });
                }
                catch (Exception ex)
                {
                    return Json(new { status = "error", message = ex.Message });
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

    }
}
