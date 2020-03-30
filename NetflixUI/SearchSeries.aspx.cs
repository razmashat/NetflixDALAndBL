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
    public partial class SearchSeries : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                GridView1.DataSource = NetflixBL.Series.GetAllSeries();
                GridView1.DataBind();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //only work with full name now should add partial as well
            string name = searchbox.Text;
            DataSet ds = NetflixBL.General.SearchSeries(name);
            if (ds.Tables["seriesByIdTbl"].Rows.Count > 0)
            {
                Session["sid"] = ds.Tables["seriesByIdTbl"].Rows[0]["SeriesID"];
                Response.Redirect("Series.aspx");
            }

        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int RowIndex = int.Parse(e.CommandArgument.ToString());
            Session["sid"] = int.Parse(GridView1.Rows[RowIndex].Cells[1].Text);
            Response.Redirect("Series.aspx");
        }
    }
}