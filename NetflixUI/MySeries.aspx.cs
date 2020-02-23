using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using NetflixBL;

namespace NetflixUI
{
    public partial class MySeries : System.Web.UI.Page
    {
        NetflixBL.User user;
        protected void Page_Load(object sender, EventArgs e)
        {
            
            if (Session["Login"] == null)
            {
                Response.Redirect("Main.aspx");
            }
            
           
            user = new NetflixBL.User((string)Session["Username"]);
            user.GetSeries();
            
            DataList1.DataSource = user.SeriesList1;
            if (!IsPostBack)
            {
                DataList1.DataBind();
            }
        }

        protected void DataList1_ItemDataBound(object sender, DataListItemEventArgs e)
        {
            int i = e.Item.ItemIndex;
            NetflixBL.Series s = user.SeriesList1[i];
            ((Label)e.Item.FindControl("sname")).Text = s.seriesName;
            ((Label)e.Item.FindControl("sid")).Text = s.seriesID.ToString();
        }

        protected void DataList1_ItemCommand(object source, DataListCommandEventArgs e)
        {
            Session["sid"] = int.Parse(((Label)e.Item.FindControl("sid")).Text);
            Response.Redirect("Series.aspx");
        }
    }
}