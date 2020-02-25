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
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string filename;
            if (FileUpload1.HasFile)
            {
                filename = @"C:\Users\User\Source\Repos\razmashat\NetflixDALAndBL\NetflixUI\vids\" + TextBox1.Text + "S" + TextBox2.Text + "E" +TextBox3.Text+Path.GetExtension(FileUpload1.FileName);
                FileUpload1.SaveAs(filename);
                WindowsMediaPlayer player = new WindowsMediaPlayer();
                var clip = player.newMedia(filename);
                double time = clip.duration;
                NetflixBL.Admin admin = new NetflixBL.Admin((int)Session["adminID"]);
                admin.AddEpisode(int.Parse(TextBox1.Text),int.Parse(TextBox2.Text),int.Parse(TextBox3.Text),TextBox4.Text,(int)time,filename);
                
            }
        }
    }
}