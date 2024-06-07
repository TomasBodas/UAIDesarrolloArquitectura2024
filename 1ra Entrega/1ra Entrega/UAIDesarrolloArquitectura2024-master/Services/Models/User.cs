using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Services.Models
{
    public class User
    {
        public int id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int DNI { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public bool IsBlocked { get; set; }
        public int Attempts { get; set; }

        public User(object[] itemArray) : base()
        {
            this.id = (int)itemArray[0];
            this.Name = (string)itemArray[1];
            this.Surname = (string)itemArray[2];
            this.DNI = (int)itemArray[3];
            this.Email = (string)itemArray[4];
            this.Password = (string)itemArray[5];
        }

    }
}