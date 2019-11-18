using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using DrivingDAL;

namespace NetflixDAL
{
   public class SeriesDAL
    {


        const string TABEL = "SeriesTBL";
        const string TABEL1 = "PlayListAndSeriesTBL";
        const string TABEL2 = "SeriesAndUserTBL";
        const string TABEL3 = "episodeTBL";
        const string filed1 = "SeriesID";
        const string filed2 = "SeriesName";
        const string filed3 = "SeriesAdmin";
        const string filed4 = "description";



        public static string stringbuilder(string s)
        {

            return "\"" + s + "\"";
        }

        public static void Insert(string seriename, int admin, string description)
        {
             seriename = stringbuilder(seriename);
            string admin1 = stringbuilder(admin.ToString());
            description = stringbuilder(description);
            OleDbHelper.InsertWithAutoNumKey("INSERT INTO " + TABEL + "(" + filed2 + "," + filed3 + "," + filed4 + ") VALUES (" + seriename + "," + admin + "," + description + ")");

           
        }
        public static DataSet GetAll()
        {
            return OleDbHelper.Fill("select * from " + TABEL, TABEL);
        }

        public static DataSet GetSeriesByID(int id)
        {
            string id1 = stringbuilder(id.ToString());
            return OleDbHelper.Fill("select * from " + TABEL + " WHERE " + filed1 + " = " + id, "seriesByIdTbl");
        }


        public static DataSet GetSeriesByAdmin(int id)
        {
            string id1 = stringbuilder(id.ToString());
            return OleDbHelper.Fill("select * from " + TABEL + " WHERE " + filed3 + " = " + id, "seriesByAdminTbl");
        }


        public static DataSet InnerjoinUser(int id)
        {


            return OleDbHelper.Fill("SELECT SeriesTBL.SeriesID, SeriesAndUserTBL.UserID FROM " + TABEL + " INNER JOIN " + TABEL2 + " ON SeriesTBL.SeriesID = SeriesAndUserTBL.SeriesID WHERE SeriesAndUserTBL.SeriesID = " + id, "uandstbl");


        }


        public static DataSet InnerjoinPlayList(int id)
        {


            return OleDbHelper.Fill("SELECT SeriesTBL.SeriesID, PlayListAndSeriesTBL.PlayListID FROM " + TABEL + " INNER JOIN " + TABEL1 + " ON SeriesTBL.SeriesID = PlayListAndSeriesTBL.SeriesID WHERE PlayListAndSeriesTBL.SeriesID = " + id, "pandstbl");


        }



 



        public static void UpdateUserBySubID(string des, int admin, string name, int subid)
        {
            // OleDbHelper.DoQuery("UPDATE UserTBL SET pass='" + pass + "', MyAdmin='" + MyAdmin + "',sub='" + sub + "' , email='" + email + "' WHERE username='" + username+ "'");
            des = stringbuilder(des);
            string admin1 = stringbuilder(admin.ToString());
            name = stringbuilder(name);
            string id = stringbuilder(subid.ToString());
            OleDbHelper.DoQuery("UPDATE " + TABEL + " SET " + filed2 + "=" + name + ", " + filed3 + "=" + admin + "," + filed4 + "=" + des + " WHERE " + filed1 + "=" + subid.ToString());
        }

        public static DataSet InnerjoinEpi(int id)
        {


            return OleDbHelper.Fill("SELECT SeriesTBL.SeriesID, episodeTBL.EpisdeID FROM " + TABEL + " INNER JOIN " + TABEL3 + " ON episodeTBL.EpiSeries = SeriesTBL.SeriesID WHERE SeriesTBL.SeriesID = " + id, "pandstbl");


        }

        public static bool IsExist(int ID)
        {

            DataSet ds = GetSeriesByID(ID);
            return (ds.Tables["seriesByIdTbl"].Rows.Count > 0);


        }
    }
}
