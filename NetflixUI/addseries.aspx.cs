﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using NetflixBL;

namespace NetflixUI
{
    public partial class addseries : System.Web.UI.Page
    {
        public static string error;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!((string)Session["Login"] == "admin"))
                if (((string)Session["Login"] == "user"))
                    Response.Redirect("User.aspx");
                else
                    Response.Redirect("Login.aspx"); 
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                NetflixBL.Admin admin = new NetflixBL.Admin((int)Session["adminID"]);
                admin.CreateSeries(TextBox1.Text,TextBox2.Text,DropDownList1.SelectedItem.Text,TextBox3.Text);
                error = "series created!";
            }
        }
    }
}