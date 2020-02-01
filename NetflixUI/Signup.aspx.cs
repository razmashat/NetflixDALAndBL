using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NetflixUI
{
    public partial class Signup : System.Web.UI.Page
    {
        public string err = "";
        protected void Page_Load(object sender, EventArgs e)
        {

            if (Page.IsValid)
            {
              bool worked =  NetflixBL.General.SignUp(username.Text,password.Text,1,subscription.SelectedIndex + 1,email.Text);
                if (worked)
                {
                    err = "username alredy esixst! please change username";
                    return;
                }
                err = "you have sucsussfully signed up!";
            }

        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}