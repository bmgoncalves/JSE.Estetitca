using JSE.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace JSE.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("{area:exists}/{controller=Dashboard}/{action=Index}/{id?}")]
    public class DashboardController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        //[Route("Home/About")]
        public ActionResult Contato()
        {
            //return RedirectToAction("Index", "Contato", new { area = "Atendimento" });
            return RedirectToAction("Index", "Contato", new { area = "Admin" });
        }
        
        public ActionResult Servico()
        {
            return RedirectToAction("Index", "Servico", new { area = "Admin" });
        }


        [HttpPost]
        public ActionResult Login(Usuario usuario)
        {
            return RedirectToAction("Index", "Servico", new { area = "Admin" });
        }

        [HttpPost]
        public ActionResult RecuperarSenha(string email)
        {
            return RedirectToAction("Index", "Servico", new { area = "Admin" });
        }

    }
}