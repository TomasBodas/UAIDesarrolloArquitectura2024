using Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class SessionManager
    {
        public void login(User pUser)
        {
            if (!UserInstance.getInstance().userIsLoggedIn())
            {
                UserInstance.getInstance().user = pUser;
            }
            else
            {
                //break
            }
        }
        public void logout()
        {
            if (UserInstance.getInstance().userIsLoggedIn())
            {
                UserInstance.getInstance().user = null;

            }
            else
            {
                //break
            }
        }
    }
}
