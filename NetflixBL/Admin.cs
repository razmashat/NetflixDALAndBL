using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NetflixDAL;
using System.Data;

namespace NetflixBL
{
    public class Admin
    {
        private int AdminID;
        private string AdminName;
        private string AdminPassword;
        private List<User> myUsers;
        private List<Series> MySeries;

        public int adminID { get => AdminID; set { } }
        public string adminName { get => AdminName; set { } }
        public string adminPassword { get => AdminPassword; set { } }
        public List<User> MyUsers { get => myUsers; set { } }
        internal List<Series> mySeries { get => MySeries; set { } }

        public Admin(int ID) {
            DataSet ds = AdminDAL.GetAdminByID(ID);
            AdminID = int.Parse(ds.Tables["adminByIdTbl"].Rows[0]["AdminID"].ToString());
            AdminName = ds.Tables["adminByIdTbl"].Rows[0]["AdminName"].ToString();
            AdminPassword = ds.Tables["adminByIdTbl"].Rows[0]["AdminPassword"].ToString();
            GetUsers();
            GetSeries();

        }

        public void GetSeries()
        {
            MySeries = new List<Series>();
            DataSet ds = SeriesDAL.GetSeriesByAdmin(AdminID);
            for (int i = 0; i < ds.Tables["seriesByAdminTbl"].Rows.Count; i++)
            {
                MySeries.Add(new Series(int.Parse(ds.Tables["seriesByAdminTbl"].Rows[i]["SeriesID"].ToString())));
            }

        }


        public void GetUsers()
        {

            DataSet ds = UserDAL.GetuserByAdmin(AdminID);
            for (int i = 0; i < ds.Tables["userByAdminTbl"].Rows.Count; i++)
            {
                MyUsers.Add(new User((ds.Tables["userByAdminTbl"].Rows[i]["username"].ToString())));
            }

        }

        public void CreateSeries(string name,string descreption,string genre)
        {

            SeriesDAL.Insert(name,AdminID,descreption,genre);
            GetSeries();

        }

        public bool AddEpisode(int SID, int EID, int ENUM,string name,int length,string url)
        {

            if (episodeDAL.IsExistSeries(SID,EID,ENUM))
            {

                return false;

            }

            episodeDAL.Insert(name,length,SID,EID,ENUM,url);
            return true;

        }

    }
}
