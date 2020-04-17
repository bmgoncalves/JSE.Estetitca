using JSE.Web.Data;
using JSE.Web.Models;
using JSE.Web.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Diagnostics;
using System.Linq;

namespace JSE.Web.Controllers
{
    public class HomeController : Controller
    {
        public JSEContext _context { get; set; }

        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, JSEContext contexto)
        {
            _logger = logger;
            _context = contexto;
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

    }
}
