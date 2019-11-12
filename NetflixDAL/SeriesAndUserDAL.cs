using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using DrivingDAL;


namespace NetflixDAL
{
    class SeriesAndUserDAL
    {
        const string TABEL = "SeriesAndUserTBL";
        const string filed1 = "UserID";
        const string filed2 = "SeriesID";




        public static string stringbuilder(string s)
        {

            return "\"" + s + "\"";
        }

        public static void Insert(string uid, int sid)
        {
             uid = stringbuilder(uid);
            string sid1 = stringbuilder(sid.ToString());

            OleDbHelper.InsertWithAutoNumKey("INSERT INTO " + TABEL + "(" + filed1 + "," + filed2 + ") VALUES (" + uid + "," + sid1 + ")");

            //  OleDbHelper.DoQuery("INSERT INTO" + TABEL+ "(username,pass,MyAdmin,subscriptiontype,email) VALUES (" + username + "," + pass + "," + MyAdmin1 + "," + sub1 + "," + email + ")");
        }

        public static bool IsExist(string uid,int sid)
        {
             uid = stringbuilder(uid);
            string sid1 = stringbuilder(sid.ToString());
            DataSet ds = OleDbHelper.Fill("select * from " +TABEL+" WHERE "+filed1+"=" + uid + " AND "+ filed2+"="+sid.ToString(), "checkTBL");
            return (ds.Tables["checkTBL"].Rows.Count > 0);


        }

        public static void DelT(string uid, int sid)
        {
            string deleteSQL;
            uid = stringbuilder(uid);
            deleteSQL = "DELETE * from " + TABEL + " where " + filed1 + "=" + uid + " AND " + filed2 + "=" + sid;
            OleDbHelper.DoQuery(deleteSQL);
        }
    }
}
