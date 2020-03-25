using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using WMPLib;
using NetflixBL;

namespace NetflixUI
{
    public partial class UploadEpisode : System.Web.UI.Page
    {
        static NetflixBL.Admin admin;
        protected void Page_Load(object sender, EventArgs e)
        {
            admin = new NetflixBL.Admin((int)Session["adminID"]);
            List<NetflixBL.Series> series = admin.mySeries;
            if (!Page.IsPostBack)
            {
                for (int i = 0; i < series.Count; i++)
                {
                    DropDownList1.Items.Add(series[i].seriesName);
                    DropDownList1.Items[i].Value = series[i].seriesID.ToString();
                }
            }
          
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string filename;
            if (FileUpload1.HasFile)
            {
                filename = @"C:\Users\razma\Source\Repos\razmashat\NetflixDALAndBL\NetflixUI\vids\" + DropDownList1.SelectedItem.Text + "S" + TextBox2.Text + "E" +TextBox3.Text+Path.GetExtension(FileUpload1.FileName);
                FileUpload1.SaveAs(filename);
                WindowsMediaPlayer player = new WindowsMediaPlayer();
                var clip = player.newMedia(filename);
                double time = clip.duration;
                NetflixBL.Admin admin = new NetflixBL.Admin((int)Session["adminID"]);
                admin.AddEpisode(int.Parse(DropDownList1.SelectedItem.Value),int.Parse(TextBox2.Text),int.Parse(TextBox3.Text),TextBox4.Text,(int)time,filename);
                
            }
        }
    }
}