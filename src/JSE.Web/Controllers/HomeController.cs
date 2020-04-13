using JSE.Web.Data;
using JSE.Web.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Diagnostics;

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
            return View();
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
        public IActionResult RegistraContato(Contato contato)
        {

            return PartialView("_Footer", null);

            //if (contato != null)
            //{
            //    try
            //    {
            //        _context.Contatos.Add(contato);
            //        _context.SaveChanges();
            //        return PartialView("_Footer",null);
            //    }
            //    catch (Exception ex)
            //    {
            //        return PartialView(ex.Message);
            //    }
            //}
            //else
            //{
            //    return PartialView();
            //}

        }

    }
}
