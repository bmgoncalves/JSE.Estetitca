using Microsoft.AspNetCore.Mvc;

namespace JSE.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin")]
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
            //return View();

        }

        //[Route("Home/About")]
        public ActionResult Servico()
        {
            return RedirectToAction("Index", "Servico", new { area = "Admin" });

            //return RedirectToAction("Index", "Servico");

        }
    }
}