using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using NetflixBL;

namespace NetflixUI
{
    public partial class User : System.Web.UI.Page
    {
        public string hello = "";
        protected void Page_Load(object sender, EventArgs e)
        {
           

            if (!((string)Session["Login"] == "user"))
            {
                Response.Redirect("Login.aspx");
            }

            NetflixBL.User user = new NetflixBL.User((string)Session["Username"]);
            //hello = "<h1> hello " +  user.
        }
    }
}