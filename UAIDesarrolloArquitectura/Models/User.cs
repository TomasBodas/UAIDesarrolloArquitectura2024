using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UAIDesarrolloArquitectura.Models
{
    public class User
    {
        public string Email { get; set; }
        public bool IsBlocked { get; set; }
        public int Attempts { get; set; }
        public string Password { get; set; }
        public int DNI { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }

    }
}