using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NetflixDAL;
using System.Data;

namespace NetflixBL
{
    public class playlist
    {
        private int PlayListID;
        private string MyUser;

        public playlist(int ID)
        {
            DataSet ds = playlistDAL.GetPlayListByID(ID);
            PlayListID = int.Parse(ds.Tables["playlistByIdTbl"].Rows[0]["PlayListID"].ToString());
            MyUser = ds.Tables["playlistByIdTbl"].Rows[0]["MyUser"].ToString();
        }
    }
}
