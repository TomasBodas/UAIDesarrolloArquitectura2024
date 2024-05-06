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
        
    }
}