using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using NetflixBL;
using NetflixDAL;

namespace NetflixUI
{
    public partial class Series : System.Web.UI.Page
    {
        NetflixBL.User user;
        NetflixBL.Series s;
        public static string error;
        protected void Page_Load(object sender, EventArgs e)
        {
           user = new NetflixBL.User((string)Session["username"]);
            s = new NetflixBL.Series((int)Session["sid"]);
            user.GetSeries();
            if (user.SeriesList1.Contains(s))
            {
                add.Visible = false;
                
            }
            name.Text = s.seriesName;
            desc.Text = s.Description;
            DataSet ds = episodeDAL.GetAll();
            List<int> seasons = new List<int>();
            for (int i = 0; i < ds.Tables["episodeTBL"].Rows.Count; i++)
            {
                if (!seasons.Contains((int)ds.Tables["episodeTBL"].Rows[i]["SeasonNum"]))
                {
                    seasons.Add((int)ds.Tables["episodeTBL"].Rows[i]["SeasonNum"]);
                }
            }
            for (int i = 0; i < seasons.Count; i++)
            {
                drop.Items.Add(seasons[i].ToString());
            }
        }

        protected void add_Click(object sender, EventArgs e)
        {
            
           
            if (-1 == user.AddSeries((int)Session["sid"]))
            {
                error = "you watched the maximum amout og series you can!";
                return;
            }
            error = "added to your list!";
          
                
           
        }
    }
}