﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using NetflixBL;

namespace NetflixUI
{
    public partial class Admin : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            
            if (!((string)Session["Login"] == "admin"))
            {
                Response.Redirect("Login.aspx");
            }
            NetflixBL.Admin admin = new NetflixBL.Admin((int)Session["adminID"]);
            if (!Page.IsPostBack)
            { 
                admin.GetUsers();
                admin.GetSeries();
                GridView1.DataSource = admin.MyUsers;
                GridView1.DataBind();
                GridView2.DataSource = admin.mySeries;
                GridView2.DataBind();
            }

        }
    }
}