using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using DrivingDAL;
namespace NetflixDAL
{
  public  class SubScriptionTypeTBLDAL
    {

        const string TABEL = "SubScriptionTypeTBL";
        const string filed1 = "SubscriptionID";
        const string filed2 = "amountpermonth";
        const string filed3 = "SeriesAmount";
        const string filed4 = "description";



        public static string stringbuilder(string s) {

            return "\"" + s + "\"";
        }

        public static void Insert(int amountpaid, int samount, string description)
        {
            string amountpaid1 = stringbuilder(amountpaid.ToString());
            string samount1 = stringbuilder(samount.ToString());
            description = stringbuilder(description);
            OleDbHelper.InsertWithAutoNumKey("INSERT INTO " + TABEL + "("+filed2+ ","+filed3+","+filed4+") VALUES (" + amountpaid1 + "," + samount1+ ","+description+")");

          //  OleDbHelper.DoQuery("INSERT INTO" + TABEL+ "(username,pass,MyAdmin,subscriptiontype,email) VALUES (" + username + "," + pass + "," + MyAdmin1 + "," + sub1 + "," + email + ")");
        }
        public static DataSet GetAll()
        {
            return OleDbHelper.Fill("select * from " +TABEL , TABEL);
        }

        public static DataSet GetSubByID(int id)
        {
            string id1 = stringbuilder(id.ToString());
                         return OleDbHelper.Fill("SELECT * FROM " + TABEL +" WHERE " +filed1 +" = " +id, "subByIdTbl");
        }



        public static void UpdateUserBySubID(string des, int amount, int samonunt, int subid)
        {
            // OleDbHelper.DoQuery("UPDATE UserTBL SET pass='" + pass + "', MyAdmin='" + MyAdmin + "',sub='" + sub + "' , email='" + email + "' WHERE username='" + username+ "'");
            des = stringbuilder(des);
            string amount1 = stringbuilder(amount.ToString());
            string samount1 = stringbuilder(samonunt.ToString());
            string id = stringbuilder(subid.ToString());
            OleDbHelper.DoQuery("UPDATE " + TABEL + " SET " +filed2+ "=" + amount1 + ", " +filed3+"=" + samount1 + ","+ filed4+"=" + des +  " WHERE "+ filed1+"=" + subid.ToString());
        }


        public static bool IsExist(int ID)
        {
          
            DataSet ds = GetSubByID(ID);
            return (ds.Tables["subByIdTbl"].Rows.Count > 0);


        }

    }
}
