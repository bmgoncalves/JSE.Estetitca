using JSE.Web.Data;
using JSE.Web.Extensions;
using JSE.Web.Models;
using JSE.Web.ViewModel;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
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
                Estabel = _context.Estabelecimentos.Where(e => e.Ativo == true).FirstOrDefault(),
                Servicos = _context.Servicos.Where(s => s.ExibeIndex == true)
                                            .OrderBy(s => s.NomeServico)
                                            .Take(4)
                                            .ToList(),
                Depoimentos = _context.Depoimentos.Where(d => d.Aprovado == true)
                                                  .OrderBy(d => d.DataCriacao)
                                                  .ThenBy(d => d.NomeCliente)
                                                  .Take(20)
                                                  .ToList(),
                Galerias = _context.Galerias.Where(g => g.Exibir == true)
                                            .OrderBy(g => g.GaleriaId)
                                            .ThenBy(g => g.ServicoId)
                                            .ToList(),
                Categorias = _context.ServicoCategorias.OrderBy(c => c.CategoriaId).ToList()
            };

            //Buscar o nome do serviço 
            foreach (var g in idx.Galerias)
            {
                var servico = _context.Servicos.Where(s => s.ServicoId == g.ServicoId).FirstOrDefault();
                g.NomeServico = servico.NomeServico;
                g.NomeCategoria = _context.ServicoCategorias.Where(c => c.CategoriaId == servico.CategoriaId)
                                                            .Select(c => c.Categoria)
                                                            .Single();
            }

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
        public async Task<IActionResult> Depoimento(Depoimento depoimento, IEnumerable<IFormFile> files)
        {

            if (ModelState.IsValid)
            {
                Random rand = new Random();
                var fileName = Util.GenerateCoupon(10, rand);
                var uploads = Path.Combine(_env.WebRootPath, "images\\uploads\\depoimentos\\");
                var usuario = depoimento.NomeCliente;
                try
                {
                    _context.Depoimentos.Add(depoimento);

                    foreach (var file in files)
                    {
                        if (file != null && file.Length > 0)
                        {
                            fileName += Path.GetExtension(file.FileName);

                            //var fileName = Guid.NewGuid().ToString().Replace("-", "") +
                            //                Path.GetExtension(file.FileName);
                            using (var s = new FileStream(Path.Combine(uploads, fileName),
                                                                        FileMode.Create))
                            {
                                await file.CopyToAsync(s);
                                depoimento.Imagem = uploads + fileName;
                                depoimento.NomeArquivo = fileName;
                            }
                        }
                    }

                    _context.SaveChanges();

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

        public IActionResult Servicos()
        {
            var servicos = _context.Servicos.OrderBy(s => s.NomeServico).ThenBy(s => s.ServicoId).ToList();
            //var lista = new List<Servico>();
            return View(servicos);
        }

        public IActionResult Galerias()
        {

            var query = from g in _context.Galerias.OrderBy(g => g.GaleriaId).ThenBy(s => s.ServicoId).ToList() // outer sequence
                        join s in _context.Servicos //inner sequence 
                        on g.ServicoId equals s.ServicoId // key selector 
                        select new
                        {
                            g.GaleriaId,
                            g.ServicoId,
                            s.NomeServico,
                            g.NomeCategoria,
                            g.NomeCliente,
                            g.Imagem,
                            g.NomeArquivo,
                            g.DataCadastro,
                            g.Exibir,
                        };

            IList<Galeria> lista = new List<Galeria>();

            foreach (var item in query)
            {
                var g = new Galeria()
                {
                    ServicoId = item.ServicoId,
                    GaleriaId = item.GaleriaId,
                    NomeCliente = item.NomeCliente,
                    NomeServico = item.NomeServico,
                    NomeCategoria = item.NomeCategoria,
                    NomeArquivo = item.NomeArquivo,
                    Imagem = item.Imagem,
                    DataCadastro = item.DataCadastro,
                    Exibir = item.Exibir
                };

                lista.Add(g);

            }
            return View(lista);
        }

    }
}
