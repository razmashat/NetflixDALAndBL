using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using DrivingDAL;



namespace NetflixDAL
{
    public class playlistandseriesDAL
    {



        const string TABEL = "PlayListAndSeriesTBL";
        const string filed1 = "PlayListID";
        const string filed2 = "SeriesID";
        



        public static string stringbuilder(string s)
        {

            return "\"" + s + "\"";
        }

        public static void Insert(int pid, int sid)
        {
            string pid1 = stringbuilder(pid.ToString());
            string sid1 = stringbuilder(sid.ToString());

            OleDbHelper.InsertWithAutoNumKey("INSERT INTO " + TABEL + "(" + filed1 + "," + filed2 + ") VALUES (" + pid1 + "," + sid1 + ")");

            //  OleDbHelper.DoQuery("INSERT INTO" + TABEL+ "(username,pass,MyAdmin,subscriptiontype,email) VALUES (" + username + "," + pass + "," + MyAdmin1 + "," + sub1 + "," + email + ")");
        }
        public static void DelT(int sid, int pid)
        {
            string deleteSQL;
            deleteSQL = "DELETE * from "+TABEL + " where "+filed1+"=" + pid+ " AND "+filed2+"="+sid;
            OleDbHelper.DoQuery(deleteSQL);
        }



        public static bool IsExist(int pid , int sid)
        {
          //  uid = stringbuilder(uid);
           // string sid1 = stringbuilder(sid.ToString());
            DataSet ds = OleDbHelper.Fill("select * from " + TABEL + " WHERE " + filed1 + "=" + pid + " AND " + filed2 + "=" + sid.ToString(), "checkTBL");
            return (ds.Tables["checkTBL"].Rows.Count > 0);


        }



    }
}
