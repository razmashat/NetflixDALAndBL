using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace NetflixUI
{
    public partial class SearchSeries : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //only work with full name now should ad partial as well
            string name = searchbox.Text;
            DataSet ds = NetflixBL.General.SearchSeries(name);
            if (ds.Tables["seriesByIdTbl"].Rows.Count > 0)
            {
                Session["sid"] = ds.Tables["seriesByIdTbl"].Rows[0]["SeriesID"];
                Response.Redirect("Series.aspx");
            }

        }
    }
}