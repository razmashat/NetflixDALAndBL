using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using DrivingDAL;

namespace NetflixDAL
{
    public class playlistDAL
    {





        const string TABEL = "playlistTBL";
        const string filed1 = "PlayListID";
        const string filed2 = "MyUser";
        const string TABEL1 = "PlayListAndSeriesTBL";



        public static string stringbuilder(string s)
        {

            return "\"" + s + "\"";
        }

        public static void Insert(string user)
        {
            user = stringbuilder(user);
            
            
            OleDbHelper.InsertWithAutoNumKey("INSERT INTO " + TABEL + "(" + filed2 +  ") VALUES (" +user + ")");

        }
        public static DataSet GetAll()
        {
            return OleDbHelper.Fill("select * from " + TABEL, TABEL);
        }


        public static DataSet GetPlayListByID(int id)
        {
            string id1 = stringbuilder(id.ToString());
            return OleDbHelper.Fill("select * from " + TABEL + " WHERE " + filed1 + " = " + id, "playlistByIdTbl");
        }


        public static DataSet InnerjoinSeries(int id) {


            return OleDbHelper.Fill("SELECT playlistTBL.PlayListID, PlayListAndSeriesTBL.SeriesID FROM " + TABEL+" INNER JOIN "+TABEL1+ " ON playlistTBL.PlayListID = PlayListAndSeriesTBL.PlayListID WHERE PlayListAndSeriesTBL.PlayListID = "+id, "pandstbl");


        }


        public static void UpdatePlaylistByID(string user, int subid)
        {
          
            user = stringbuilder(user);
          
          
            string id = stringbuilder(subid.ToString());
            OleDbHelper.DoQuery("UPDATE " + TABEL + " SET " + filed2 + "=" + user+ " WHERE " + filed1 + "=" + subid.ToString());
        }

        public static bool IsExist(int ID)
        {

            DataSet ds = GetPlayListByID(ID);
            return (ds.Tables["playlistByIdTbl"].Rows.Count > 0);


        }

    }
}
