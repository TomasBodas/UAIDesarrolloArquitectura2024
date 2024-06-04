using DAL;
using Services;
using Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;
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
            try
            {
                if (ModelState.IsValid)
                {
                    User user;
                    DAL_Usuarios dalUser = new DAL_Usuarios();
                    //Retrieves user from database
                    user = dalUser.findByEmail(model.Email);
                    string Hash = PasswordEncrypter.EncryptPassword(model.Password);
                    if (user != null)
                    {
                        SessionManager sessionManager = new SessionManager();
                        if (dalUser.userPasswordMatcher(user.Password, Hash))
                        {
                            //Singleton setup
                            sessionManager.login(user);
                            dalUser.EventLog(user.DNI, DateTime.Now.ToString(), "Inicio de sesión", "Se inició sesión");
                        }
                        else throw new Exception();
                        return RedirectToAction("Index", "Home");
                    }
                    else throw new Exception();
                }
            } catch (Exception) { ModelState.AddModelError("MissingUser", "No existe un usuario con estos datos"); }
            
            return View(model);
        }
    }
}