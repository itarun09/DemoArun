using Demo.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.DL
{
    public class Login : ILogin
    {
        private DemoTestEntities _DBContext;

        public Login()
        {
            _DBContext = new DemoTestEntities();
        }
        public bool ValidateUser(string UserID, string Pwd)
        {
            bool result = false;
            try
            {
                var UserDetais = _DBContext.UserDetais.Where(m => m.UserName.ToLower() == UserID.ToLower() && m.UserPassword.ToLower() == Pwd.ToLower()).FirstOrDefault();
                if(UserDetais!=null)
                {
                    result = true;
                }
            }

            catch (Exception ex)
            {


            }
            return result;

        }
    }
}
