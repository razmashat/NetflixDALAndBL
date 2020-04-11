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
        static List<NetflixBL.Series> slist;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                slist = NetflixBL.Series.GetAllSeries();
                //GridView1.DataSource = NetflixBL.Series.GetAllSeries();
                DataList1.DataSource = slist;
                DataList1.DataBind();
                //GridView1.DataBind();
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

        protected void DataList1_ItemDataBound(object sender, DataListItemEventArgs e)
        {
            int i = e.Item.ItemIndex;
            NetflixBL.Series s = slist[i];
            ((Button)e.Item.FindControl("sname")).Text = s.seriesName;
            ((Label)e.Item.FindControl("sid")).Text = s.seriesID.ToString();
            ((Image)e.Item.FindControl("sposter")).ImageUrl = s.Posterurl;
            ((Label)e.Item.FindControl("sdesc")).Text = s.Description;
        }

        protected void DataList1_ItemCommand(object source, DataListCommandEventArgs e)
        {
            Session["sid"] = int.Parse(((Label)e.Item.FindControl("sid")).Text);
            Response.Redirect("Series.aspx");
        }
    }
}