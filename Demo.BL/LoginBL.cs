using Demo.DL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.BL
{
   public class LoginBL: ILoginBL
    {
        private Login _Login;
        public LoginBL()
        {
            _Login = new Login();
        }
        public bool ValidateUser(string UserID, string Pwd)
        {
            bool result = false;
            try
            {
                return _Login.ValidateUser(UserID, Pwd);
            }

            catch (Exception ex)
            {


            }
            return result;

        }
    }
}
