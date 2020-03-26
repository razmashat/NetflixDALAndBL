using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using NetflixBL;

namespace NetflixUI
{
    public partial class Episode : System.Web.UI.Page
    {
        static string username;
        static int EpiID;
        public static string error = "";
        static Rate rate;
        static NetflixBL.Episode epi;
        protected void Page_Load(object sender, EventArgs e)
        {

            username = (string)Session["Username"];
            EpiID = (int)Session["EpiID"];


            if (NetflixBL.Rate.IsExistUser(username,EpiID))
            {
                rate = new NetflixBL.Rate(username,EpiID);
                DropDownList1.Visible = false;
                Rate.Visible = false;
                MyRate.Visible = true;
                MyRate.Text = rate.starts.ToString() + "/5";
            }
            else
            {
                DropDownList1.Visible =true;
                Rate.Visible = true;
                MyRate.Visible = false;
            }

            epi = new NetflixBL.Episode(EpiID);
            EpiName.Text = epi.episodeName;
            Time.Text = epi.episodeLength.ToString() + " minutes";
            AvgRate.Text = epi.avgrate.ToString() + "/5";
        }

        protected void Rate_Click(object sender, EventArgs e)
        {
            if (!NetflixBL.Rate.DoRate(username,EpiID,DropDownList1.SelectedIndex + 1))
            {
                error = "cant rate this episode with this user";
                return;
            }
            error = "rated taht episode secsussfuly";   
        }

        protected void Watch_Click(object sender, EventArgs e)
        {
            Session["Link"] = epi.epiURL;
            Response.Redirect("WatchEpisode.aspx");
        }
    }
}