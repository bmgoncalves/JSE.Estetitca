using Microsoft.AspNetCore.Mvc;

namespace JSE.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    //[Route("Admin/Dashboard/Index")]
    public class DashboardController : Controller
    {
        // GET: Home
        [Route("{area:exists}/{controller=Dashboard}/{action=Index}/{id?}")]
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
    }
}