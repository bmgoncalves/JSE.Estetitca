using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JSE.Web.Areas.Admin.ViewModel;
using JSE.Web.Data;
using JSE.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace JSE.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class LoginController : Controller
    {
        //private Usuario usuario;
        private JSEContext _context;
        public LoginController(JSEContext context)
        {
            //usuario = _usuario;
            _context = context;
        }
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Autentica(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                Usuario usuario = _context.Usuario.Where(u => u.Email == model.LoginName && u.Senha == model.Password).FirstOrDefault();
                if (usuario != null)
                {
                    return RedirectToAction("Index", "Home", new { area = "Admin" });
                }
                {
                    ModelState.AddModelError("login.Invalido", "Login ou senha incorretos");
                }
                
            }
            return View("Login", model);
        }

        public IActionResult RecuperarSenha()
        {
            return View();
        }
    }
}