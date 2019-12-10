using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using NetflixBL;

namespace NetflixUI
{
    public partial class Login : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

       
        protected void LoginButton_Click(object sender, EventArgs e)
        {
            int result = General.Login(usernameTextbox.Text,passwordTextbox.Text);
            switch (result)
            {
                case 1:
                    Session["Login"] = "user";
                    Response.Redirect("User.aspx");
                    break;
                case 2:
                    Session["Login"] = "admin";
                    Response.Redirect("Admin.aspx");
                    break;

                default:
                    break;
            }
        }
    }
}