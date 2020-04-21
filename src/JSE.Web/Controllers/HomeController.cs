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

        //public async Task<IActionResult> AddOrEdit([Bind("Id,NomeServico,Descricao,Duracao")] Servico servico)
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
        public async Task<IActionResult> Depoimento(List<IFormFile> files, Depoimento d)
        {
            long size = files.Sum(f => f.Length);
            var filePaths = new List<string>();

            string diretorio = $"{_env.ContentRootPath}\\Files\\Upload\\Depoimentos\\";

            foreach (var formFile in files)
            {
                if (formFile.Length > 0)
                {
                    string nomeArquivo = Path.GetRandomFileName();
                    string nomeArquivoNovo = Path.ChangeExtension(nomeArquivo, ".png");

                    while (System.IO.File.Exists(diretorio + nomeArquivoNovo))
                    {
                        nomeArquivo = Path.GetRandomFileName();
                        nomeArquivoNovo = Path.ChangeExtension(nomeArquivo, ".png");
                    }

                    //Caminho completo da imagem
                    filePaths.Add(diretorio + nomeArquivoNovo);

                    using (var stream = new FileStream(diretorio + nomeArquivoNovo, FileMode.Create))
                    {
                        await formFile.CopyToAsync(stream);
                    }
                }
            }
            return Ok(new { count = files.Count, size, filePaths });
        }

    }
}
