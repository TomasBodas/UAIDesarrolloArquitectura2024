using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class PasswordEncrypter
    {
        public static string EncryptPassword(string pContraseña)
        {
            //Utilizamos la función de hash criptográfico proporcionada por la clase SHA256Managed
            using (SHA256Managed sha256 = new SHA256Managed())
            {
                //La contraseña se convierte en una secuencia de bytes utilizando la codificación UTF-8
                byte[] bytes = Encoding.UTF8.GetBytes(pContraseña);
                //Se calcula el hash utilizando SHA256Managed.ComputeHash
                byte[] hash = sha256.ComputeHash(bytes);
                //El hash resultante se convierte en una cadena hexadecimal utilizando StringBuilder
                StringBuilder sb = new StringBuilder();
                {
                    foreach (byte b in hash)
                    {
                        sb.Append(b.ToString("x2"));
                    }
                }
                //Se devuelve como resultado
                return sb.ToString();
            }
        }
    }
}
