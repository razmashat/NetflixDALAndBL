using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NetflixDAL;
using System.Data;

namespace NetflixBL
{
    public class User
    {
        private string username;
        private string pass;
        private int MyAdmin;
        private int subscriptiontype;
        private string email;
        private List<Series> SeriesList;

        private List<playlist> PlaylistList;

        public User (string ID){

            DataSet ds = UserDAL.GetuserByID(ID);
            username = ds.Tables["adminByIdTbl"].Rows[0]["username"].ToString();
            pass = ds.Tables["adminByIdTbl"].Rows[0]["pass"].ToString();
            subscriptiontype = int.Parse(ds.Tables["adminByIdTbl"].Rows[0]["subscriptiontype"].ToString());
            MyAdmin = int.Parse(ds.Tables["adminByIdTbl"].Rows[0]["MyAdmin"].ToString());
            email = ds.Tables["adminByIdTbl"].Rows[0]["email"].ToString();
            SeriesList = new List<Series>();
            

        }

        public void GetSeries()
        {
            
            DataSet ds = UserDAL.InnerjoinSeries(username);
            for (int i = 0; i < ds.Tables["sandstbl"].Rows.Count; i++)
            {
                SeriesList.Add(new Series(int.Parse(ds.Tables["sandstbl"].Rows[i]["SeriesID"].ToString())));
            }

        }


        public void GetPlaylist() 
        {
            
            DataSet ds = playlistDAL.GetPlaylistByUser(username);
            for (int i = 0; i < ds.Tables["playlistByUser"].Rows.Count; i++) 
            {
                PlaylistList.Add(new playlist(int.Parse(ds.Tables["playlistByUser"].Rows[i]["PlayListID"].ToString())));
            } 
        }


        public bool Rate(int EpiID,int Stars)
        {

            if (rateDAL.IsExistUser(username,EpiID))
            {
                return false;
            }

            rateDAL.Insert(username,EpiID,Stars);
            return true;

        }

        public DataSet SearchSeries(string name)
        {

            return SeriesDAL.GetSeriesByName(name);

        }


        public int AddSeries(int sid)
        {
            Subscription sub = new Subscription(subscriptiontype);
            if (SeriesList.Count >= sub.Seriesamount)
            {
                return -1;
            }

            SeriesAndUserDAL.Insert(username,sid);
            return 0;
        }
    }
}
