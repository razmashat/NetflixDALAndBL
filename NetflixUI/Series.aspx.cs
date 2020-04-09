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
        static NetflixBL.Series s;
        public static string error;
        protected void Page_Load(object sender, EventArgs e)
        {
            error = "";
           user = new NetflixBL.User((string)Session["username"]);
            s = new NetflixBL.Series((int)Session["sid"]);
            user.GetSeries();
            drop.Visible = false;
            GridView1.Visible = false;
            for (int i = 0; i < user.SeriesList1.Count; i++)
            {
                bool a = user.SeriesList1[i].seriesID == s.seriesID;
                if (a==true)
                {
                    add.Visible = false;
                    drop.Visible = true;
                    GridView1.Visible = true;
                    break;
                }
            }
            name.Text = s.seriesName;
            desc.Text = s.Description;
            Stats.Text = "watched by " + s.GetWatchers().ToString() + " users";
            DataSet ds = episodeDAL.GetAll();
            List<int> seasons = new List<int>();
            for (int i = 0; i < ds.Tables["episodeTBL"].Rows.Count; i++)
            {
                if (!seasons.Contains((int)ds.Tables["episodeTBL"].Rows[i]["SeasonNum"]) && (int)ds.Tables["episodeTBL"].Rows[i]["EpiSeries"] == s.seriesID)
                {
                    seasons.Add((int)ds.Tables["episodeTBL"].Rows[i]["SeasonNum"]);
                }
            }
            if (!Page.IsPostBack)
            {
                for (int i = 0; i < seasons.Count; i++)
                {
                    drop.Items.Add(seasons[i].ToString());
                }
                SeriesPoster.ImageUrl = s.Posterurl;

                DataSet ds1 = episodeDAL.GetAll();
                List<NetflixBL.Episode> episodes = new List<NetflixBL.Episode>();
                if (seasons.Count > 0)
                {
                    for (int i = 0; i < ds1.Tables["episodeTBL"].Rows.Count; i++)
                    {
                        if ((int)ds1.Tables["episodeTBL"].Rows[i]["SeasonNum"] == seasons[0] && (int)ds.Tables["episodeTBL"].Rows[i]["EpiSeries"] == s.seriesID)
                        {
                            NetflixBL.Episode episode = new NetflixBL.Episode((int)ds1.Tables["episodeTBL"].Rows[i]["EpisdeID"]);
                            episodes.Add(episode);
                        }
                        GridView1.DataSource = episodes;
                        GridView1.DataBind();
                    }

                }

            }
        
        }

        protected void add_Click(object sender, EventArgs e)
        {
            
           
            if (-1 == user.AddSeries((int)Session["sid"]))
            {
                error = "you watched the maximum amount of series you can!";
                return;
            }
            error = "added to your list!";
          
                
           
        }

        protected void drop_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataSet ds = episodeDAL.GetAll();
            List<NetflixBL.Episode> episodes = new List<NetflixBL.Episode>();
            for (int i = 0; i < ds.Tables["episodeTBL"].Rows.Count; i++)
            {
                if ((int)ds.Tables["episodeTBL"].Rows[i]["SeasonNum"] == int.Parse(drop.SelectedItem.Text) && (int)ds.Tables["episodeTBL"].Rows[i]["EpiSeries"] == s.seriesID)
                {
                    NetflixBL.Episode episode = new NetflixBL.Episode((int)ds.Tables["episodeTBL"].Rows[i]["EpisdeID"]);
                    episodes.Add(episode);
                }
                GridView1.DataSource = episodes;
                GridView1.DataBind();
            }
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int RowIndex = int.Parse(e.CommandArgument.ToString());
            Session["EpiID"] = int.Parse(GridView1.Rows[RowIndex].Cells[1].Text);
            Response.Redirect("Episode.aspx");
        }
    }
}