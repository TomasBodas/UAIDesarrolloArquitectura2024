using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;
using DAL;
using Services;

namespace UAIDesarrolloArquitectura.Controllers
{
    public class RegisterController : Controller
    {
        public ActionResult Register()
        {
            return View("Register");
        }

        [HttpPost]
        public ActionResult Register(string Name,string Surname,int DNI, string Email, string Password, string ConfirmPassword)
        {

            if (Password != ConfirmPassword)
            {
                ModelState.AddModelError("ConfirmPassword", "La contraseña no coincide.");
            }
            if (ModelState.IsValid)
            {
                DAL_Usuarios dal_usuarios = new DAL_Usuarios();
                string Hash = PasswordEncrypter.EncryptPassword(Password);
                dal_usuarios.RegisterUser(Name, Surname, DNI, Email, Hash);
                dal_usuarios.EventLog(DNI, DateTime.Now.ToString(), "Registro", "Se creó una cuenta");
                // Your registration logic here, e.g., save to database, etc.


                // On successful registration, redirect to another page
                return RedirectToAction("Login", "Login");
            }

            return View();
        }
    }
}