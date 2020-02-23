using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NetflixUI
{
    public partial class MastePage : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if ((string)Session["Login"] == "user")
            {
                Button1.Text = "Profile";
                Button2.Text = "Sign out";
                Button3.Text = "My Series";
            }
            else if ((string)Session["Login"] == "admin")
            {
                Button1.Text = "Admin Page";
                Button2.Text = "Sign out";
                Button3.Visible = false;
            }
            else
            {
                Button1.Text = "Log in";
                Button2.Text = "Sign up";
                Button3.Visible = false;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if ((string)Session["Login"] == "user")
            {
                Response.Redirect("User.aspx");
            }
            else if ((string)Session["Login"] == "admin")
            {
                Response.Redirect("Admin.aspx");
            }
            else
            {
                Response.Redirect("Login.aspx");
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            if ((string)Session["Login"] == "user" || (string)Session["Login"] == "admin")
            {
                Response.Redirect("Signout.aspx");
            }
            else
            {
                Response.Redirect("Signup.aspx");
            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            if ((string)Session["Login"] == "user")
            {
                Response.Redirect("MySeries.aspx");
            }
        }
    }
}