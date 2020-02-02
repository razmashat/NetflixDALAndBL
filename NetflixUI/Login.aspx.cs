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
         public string error;
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                error = "";
            }
        }

       
        protected void LoginButton_Click(object sender, EventArgs e)
        {
            int result = General.Login(usernameTextbox.Text,passwordTextbox.Text);
            switch (result)
            {
                case 1:
                    Session["Login"] = "user";
                    Session["Username"] = usernameTextbox.Text;
                    Response.Redirect("User.aspx");
                    break;
                case 2:
                    Session["Login"] = "admin";
                    Session["adminID"] = int.Parse(usernameTextbox.Text);
                    Response.Redirect("Admin.aspx");
                    break;

                default:
                    error = "failed to login";
                    break;
            }
        }
    }
}