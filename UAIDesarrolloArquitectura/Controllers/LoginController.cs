using DAL;
using Services;
using Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UAIDesarrolloArquitectura.Models.ViewModel;

namespace UAIDesarrolloArquitectura.Controllers
{
    public class LoginController : Controller
    {
        public ActionResult Startup()
        {
            return View("Login");
        }

        [HttpGet]
        public ActionResult Login()
        {
            return View("Login");
        }

        [HttpPost]
        public ActionResult Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                User user;
                DAL_Usuarios dalUser = new DAL_Usuarios();
                //Retrieves user from database
                user = dalUser.findByEmail(model.Email);

                if (user != null)
                {
                    SessionManager sessionManager = new SessionManager();
                    if (dalUser.userPasswordMatcher(user.id, model.Password))
                    {
                        //Singleton setup
                        sessionManager.login(user);

                    }
                    return RedirectToAction("Index", "Home");
                }
            }

            return View(model);
        }
    }
}