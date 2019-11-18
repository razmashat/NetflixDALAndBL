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
        private string username { get; }
        private string pass { get; }
        private int MyAdmin { get; }
        private int subscriptiontype { get; }
        private string email { get; }
        private List<Series> SeriesList { get; }

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
    }
}
