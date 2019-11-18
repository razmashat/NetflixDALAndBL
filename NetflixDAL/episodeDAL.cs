using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using DrivingDAL;

namespace NetflixDAL
{
    public class episodeDAL
    {




        const string TABEL = "episodeTBL";
        const string TABEL1 = "SeriesTBL";
        const string filed1 = "EpisdeID";
        const string filed2 = "EpisodeName";
        const string filed3 = " EpisodeLength";
        const string filed4 = "EpiSeries";
        const string filed5 = "SeasonNum";
        const string filed6 = "EpiNum";




        public static string stringbuilder(string s)
        {

            return "\"" + s + "\"";
        }

        public static void Insert(string name, int length, int series,int seasnenum,int epinum)
        {
            name = stringbuilder(name);
            string length1 = stringbuilder(length.ToString());
            string series1 = stringbuilder(series.ToString());
            string seannum1 = stringbuilder(seasnenum.ToString());
            string epinum1 = stringbuilder(epinum.ToString()); 
            OleDbHelper.InsertWithAutoNumKey("INSERT INTO " + TABEL + "(" + filed2 + "," + filed3 + "," + filed4 + "," + filed5+","+filed6+") VALUES (" + name + "," + length1 + "," + series1 + ","+seannum1+","+epinum1+ ")");

            //  OleDbHelper.DoQuery("INSERT INTO" + TABEL+ "(username,pass,MyAdmin,subscriptiontype,email) VALUES (" + username + "," + pass + "," + MyAdmin1 + "," + sub1 + "," + email + ")");
        }
        public static DataSet GetAll()
        {
            return OleDbHelper.Fill("select * from " + TABEL, TABEL);
        }



        public static DataSet GetepiByID(int id)
        {
            string id1 = stringbuilder(id.ToString());
            return OleDbHelper.Fill("select * from " + TABEL + " WHERE " + filed1 + " = " + id, "epiByIdTbl");
        }



        public static void UpdateUserBySubID(string name, int length, int series, int seasnenum, int epinum, int subid)
        {
            // OleDbHelper.DoQuery("UPDATE UserTBL SET pass='" + pass + "', MyAdmin='" + MyAdmin + "',sub='" + sub + "' , email='" + email + "' WHERE username='" + username+ "'");
            name = stringbuilder(name);
            string length1 = stringbuilder(length.ToString());
            string series1 = stringbuilder(series.ToString());
            string seannum1 = stringbuilder(seasnenum.ToString());
            string epinum1 = stringbuilder(epinum.ToString());
            string id = stringbuilder(subid.ToString());
            OleDbHelper.DoQuery("UPDATE " + TABEL + " SET " + filed2 + "=" + name + ", " + filed3 + "=" + length1 + ", " + filed4 + "=" + series1+ ", "+filed5+ "="+seannum1+", "+filed6+"="+epinum1+ " WHERE " + filed1 + "=" + subid.ToString());
        }


        public static DataSet GetEpiBySeriesID(int id)
        {
            string id1 = stringbuilder(id.ToString());
            return OleDbHelper.Fill("select * from " + TABEL + " WHERE " + filed4 + " = " + id, "epiBySidTbl");
        }


        public static bool IsExist(int ID)
        {

            DataSet ds = GetepiByID(ID);
            return (ds.Tables["epiByIdTbl"].Rows.Count > 0);


        }

    }
}
