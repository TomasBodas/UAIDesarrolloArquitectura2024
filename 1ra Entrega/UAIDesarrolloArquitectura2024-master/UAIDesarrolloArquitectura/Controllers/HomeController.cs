using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace UAIDesarrolloArquitectura.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View("Index");
        }

        public ActionResult Logout()
        {
            DAL_Usuarios dalUser = new DAL_Usuarios();
            dalUser.EventLog(Services.UserInstance.getInstance().user.DNI, DateTime.Now.ToString(), "Cierre de sesión", "Se cerró sesión");
            return View("Login");
        }
    }
}