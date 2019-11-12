using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using DrivingDAL;

namespace NetflixDAL
{
    class AdminDAL
    {



        const string TABEL = "AdminTBL";
        const string filed1 = "AdminID";
        const string filed2 = "AdminName";
        const string filed3 = "AdminPassword";



        public static string stringbuilder(string s)
        {

            return "\"" + s + "\"";
        }

        public static void Insert(string name, string pass)
        {
            name = stringbuilder(name);
             pass = stringbuilder(pass);
            
            OleDbHelper.InsertWithAutoNumKey("INSERT INTO " + TABEL + "(" + filed2 + "," + filed3 + ") VALUES (" + name + "," + pass  + ")");

            //  OleDbHelper.DoQuery("INSERT INTO" + TABEL+ "(username,pass,MyAdmin,subscriptiontype,email) VALUES (" + username + "," + pass + "," + MyAdmin1 + "," + sub1 + "," + email + ")");
        }
        public static DataSet GetAll()
        {
            return OleDbHelper.Fill("select * from " + TABEL, TABEL);
        }




        public static DataSet GetAdminByID(int id)
        {
            string id1 = stringbuilder(id.ToString());
            return OleDbHelper.Fill("select * from " + TABEL + " WHERE " + filed1 + " = " + id, "adminByIdTbl");
        }



        public static void UpdateAdminBySubID(string name, string pass, int subid)
        {
            // OleDbHelper.DoQuery("UPDATE UserTBL SET pass='" + pass + "', MyAdmin='" + MyAdmin + "',sub='" + sub + "' , email='" + email + "' WHERE username='" + username+ "'");
            name = stringbuilder(name);
            pass = stringbuilder(pass);
            string id = stringbuilder(subid.ToString());
            OleDbHelper.DoQuery("UPDATE " + TABEL + " SET " + filed2 + "=" + name + ", " + filed3 + "=" + pass + " WHERE " + filed1 + "=" + subid.ToString());
        }

        public static bool IsExist(int ID)
        {

            DataSet ds = GetAdminByID(ID);
            return (ds.Tables["adminByIdTbl"].Rows.Count > 0);


        }

    }
}
