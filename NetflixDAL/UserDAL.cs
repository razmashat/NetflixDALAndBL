using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;
using DrivingDAL;

namespace NetflixDAL
{
    class UserDAL
    {
        const string TABEL = "UserTBL";
        const string TABEL2 = "SeriesAndUserTBL";
        public static void Insert(string username, string pass, int MyAdmin, int sub,string email)
        {
            username = "\"" + username + "\"";
            pass = "\"" + pass + "\"";
            string MyAdmin1 = "\"" + MyAdmin.ToString() + "\"";
          string  sub1 = "\"" + sub.ToString() + "\"";
            email = "\"" + email + "\"";

            OleDbHelper.DoQuery("INSERT INTO UserTBL (username,pass,MyAdmin,subscriptiontype,email) VALUES (" + username + "," + pass + "," + MyAdmin1 + "," + sub1 + "," + email + ")");
        }

        public static DataSet GetAll()
        {
            return OleDbHelper.Fill("select * from UserTBL", "UserTBL");
        }

        public static void UpdateUserByUsername(string username, string pass, int MyAdmin, int sub, string email)
        {
   
            pass = "'" + pass + "'";
            string admin1 = "'" + MyAdmin.ToString() + "'";
            string sub1 = "'" + sub.ToString() + "'";
            email = "'" + email + "'";
            username = "'" + username + "'";

            OleDbHelper.DoQuery("UPDATE UserTBL SET pass=" + pass +", MyAdmin=" + admin1 + ", subscriptiontype=" + sub1 + ", email=" + email + " WHERE username=" + username);
        }

        public static bool IsExist(string username)
        {
            username = "\"" + username + "\"";
            DataSet ds = OleDbHelper.Fill("select * from UserTBL WHERE username=" + username, "UserTBL");
            return (ds.Tables["userTBL"].Rows.Count > 0);


        }


        public static DataSet InnerjoinUser(string id)
        {

            id = "\"" + id + "\"";
            return OleDbHelper.Fill("SELECT UserTBL.UserID, SeriesAndUserTBL.SeriesID FROM " + TABEL + " INNER JOIN " + TABEL2 + " ON UserTBL.UserID = SeriesAndUserTBL.UserID WHERE SeriesAndUserTBL.UserID = " + id, "sandstbl");


        }


        public static DataSet GetuserByID(string username)
        {

            username = "\"" + username + "\"";
            return OleDbHelper.Fill("select * from UserTBL WHERE username = " + username, "userByIdTbl");
        }

    }
}
