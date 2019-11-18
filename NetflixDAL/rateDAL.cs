using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using DrivingDAL;

namespace NetflixDAL
{

   
    public class rateDAL
    {

      


        const string TABEL = "rateTBL";
        const string filed1 = "RateID";
        const string filed2 = "Stars";
        const string filed3 = "Author";
        const string filed4 = "EpisodeRated";



        public static string stringbuilder(string s)
        {

            return "\"" + s + "\"";
        }

        public static void Insert(string Author, int EpisodeNum, int Starts)
        {
            Author = stringbuilder(Author);
            string EpisodeNum1 = stringbuilder(EpisodeNum.ToString());
            string Starts1 = stringbuilder(Starts.ToString());
            OleDbHelper.InsertWithAutoNumKey("INSERT INTO " + TABEL + "(" + filed2 + "," + filed3 + "," + filed4 + ") VALUES (" + Starts1 + "," + Author + "," + EpisodeNum1 + ")");

            //  OleDbHelper.DoQuery("INSERT INTO" + TABEL+ "(username,pass,MyAdmin,subscriptiontype,email) VALUES (" + username + "," + pass + "," + MyAdmin1 + "," + sub1 + "," + email + ")");
        }
        public static DataSet GetAll()
        {
            return OleDbHelper.Fill("select * from " + TABEL, TABEL);
        }


        public static DataSet GetRateByID(int id)
        {
            string id1 = stringbuilder(id.ToString());
            return OleDbHelper.Fill("select * from " + TABEL + " WHERE " + filed1 + " = " + id, "rateByIdTbl");
        }

        public static DataSet GetRateByUser(string username, int EpiID)
        {
            username = stringbuilder(username);
            return OleDbHelper.Fill("select * from " + TABEL + " WHERE " + filed3 + " = " + username + " AND " + filed4 + " = " +EpiID ,"rateByUserTbl");
        }



        public static void UpdateRateByID(string Author, int stars, int EpiNun, int subid)
        {
        
           Author = stringbuilder(Author);
            string stars11 = stringbuilder(stars.ToString());
            string EpiNun1 = stringbuilder(EpiNun.ToString());
            string id = stringbuilder(subid.ToString());
            OleDbHelper.DoQuery("UPDATE " + TABEL + " SET " + filed2 + "=" + stars11 + ", " + filed3 + "=" + Author + "," + filed4 + "=" + EpiNun1 + " WHERE " + filed1 + "=" + subid.ToString());
        }

        public static bool IsExist(int ID)
        {

            DataSet ds = GetRateByID(ID);
            return (ds.Tables["rateByIdTbl"].Rows.Count > 0);


        }

        public static bool IsExistUser(string username, int EpiID)
        {

            DataSet ds = GetRateByUser(username,EpiID);
            return (ds.Tables["rateByUserTbl"].Rows.Count > 0);


        }


    }
}
