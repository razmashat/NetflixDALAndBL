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
        private List<User> MyUsers;
        private List<Series> MySeries;

        public Admin(int ID) {
            DataSet ds = AdminDAL.GetAdminByID(ID);
            AdminID = int.Parse(ds.Tables["adminByIdTbl"].Rows[0]["AdminID"].ToString());
            AdminName = ds.Tables["adminByIdTbl"].Rows[0]["AdminName"].ToString();
            AdminPassword = ds.Tables["adminByIdTbl"].Rows[0]["AdminPassword"].ToString();

        }

        public void GetSeries()
        {

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

        public void CreateSeries(string name,string descreption)
        {

            SeriesDAL.Insert(name,AdminID,descreption);
            GetSeries();

        }

        public bool AddEpisode(int SID, int EID, int ENUM,string name,int length)
        {

            if (episodeDAL.IsExistSeries(SID,EID,ENUM))
            {

                return false;

            }

            episodeDAL.Insert(name,length,SID,EID,ENUM);
            return true;

        }

    }
}
