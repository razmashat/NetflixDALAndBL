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
        Subscription sub;
        private string email;
        private string creditCard;
        private List<Series> SeriesList;
        private List<playlist> PlaylistList;

        public string Username { get => username; set { } }
        public string Pass { get => pass; set { } }
        public int MyAdmin1 { get => MyAdmin; set { } }
        public Subscription Sub { get => sub; set { } }
        public string Email { get => email; set { } }
        public List<Series> SeriesList1 { get => SeriesList; set { } }
        public List<playlist> PlaylistList1 { get => PlaylistList; set { } }

        public string CreditCard { get => creditCard; set { } }

        public User (string ID){

            DataSet ds = UserDAL.GetuserByID(ID);
            username = ds.Tables["userByIdTbl"].Rows[0]["username"].ToString();
            pass = ds.Tables["userByIdTbl"].Rows[0]["pass"].ToString();
            sub = new Subscription(int.Parse(ds.Tables["userByIdTbl"].Rows[0]["subscriptiontype"].ToString()));
            MyAdmin = int.Parse(ds.Tables["userByIdTbl"].Rows[0]["MyAdmin"].ToString());
            email = ds.Tables["userByIdTbl"].Rows[0]["email"].ToString();
            creditCard = ds.Tables["userByIdTbl"].Rows[0]["CreditCard"].ToString();
            SeriesList = new List<Series>();
            PlaylistList = new List<playlist>();
            

        }

        public void GetSeries()
        {
            
            DataSet ds = UserDAL.InnerjoinSeries(username);
            SeriesList.Clear();
            for (int i = 0; i < ds.Tables["sandstbl"].Rows.Count; i++)
            {
                SeriesList.Add(new Series(int.Parse(ds.Tables["sandstbl"].Rows[i]["SeriesID"].ToString())));
            }

        }


        public void GetPlaylist() 
        {
            
            DataSet ds = playlistDAL.GetPlaylistByUser(username);
            PlaylistList.Clear();
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

      


        public int AddSeries(int sid)
        {
            
            if (SeriesList.Count >= sub.Seriesamount)
            {
                return -1;
            }

            SeriesAndUserDAL.Insert(username,sid);
            return 0;
        }
    }
}
