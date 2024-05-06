using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UAIDesarrolloArquitectura.Controllers
{
    public class LoginController : Controller
    {
        public ActionResult Startup()
        {
            return View("Login");
        }

        [HttpPost]
        public ActionResult Login()
        {
            return View("Index");
        }
    }
}