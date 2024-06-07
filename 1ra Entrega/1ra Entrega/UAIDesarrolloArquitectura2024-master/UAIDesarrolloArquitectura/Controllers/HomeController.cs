using DAL;
using Services;
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
        public ActionResult Startup()
        {
            return View("Index");
        }
        [HttpGet]
        public ActionResult Index()
        {
            return View("Index");
        }
        public ActionResult Plans()
        {
            return View("Plans");
        }
        public ActionResult Logout()
        {
            
            DAL_Usuarios dalUser = new DAL_Usuarios();
            dalUser.EventLog(SessionManager.GetInstance.User.DNI, DateTime.Now.ToString(), "Cierre de sesión", "Se cerró sesión");
            SessionManager.logout();
            return View("Index");
        }
    }
}