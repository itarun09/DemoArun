using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.BL
{
      interface ILoginBL
        {
            bool ValidateUser(string UserID, string Pwd);
        }
   
}
