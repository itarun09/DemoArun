using Demo.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DemoApp
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnvalidate_Click(object sender, EventArgs e)
        {
            LoginBL obj = new LoginBL();
            bool result = obj.ValidateUser(txtusername.Text.Trim(), txtpwd.Text.Trim());
            if (result) { Response.Redirect("ItemDetails.aspx");  }
            else { lblmessage.Text = "UserName/Password is not correct"; }


        }
    }
}