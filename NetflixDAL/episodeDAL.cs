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
        const string filed7 = "EpiURL";




        public static string stringbuilder(string s)
        {

            return "\"" + s + "\"";
        }

        public static void Insert(string name, int length, int series,int seasnenum,int epinum,string url)
        {
            name = stringbuilder(name);
            string length1 = stringbuilder(length.ToString());
            string series1 = stringbuilder(series.ToString());
            string seannum1 = stringbuilder(seasnenum.ToString());
            string epinum1 = stringbuilder(epinum.ToString());
            url = stringbuilder(url);
            OleDbHelper.InsertWithAutoNumKey("INSERT INTO " + TABEL + "(" + filed2 + "," + filed3 + "," + filed4 + "," + filed5+","+filed6+","+filed7+") VALUES (" + name + "," + length1 + "," + series1 + ","+seannum1+","+epinum1+ ","+url+")");

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

        public static DataSet GetepiBySeries(int SID, int EID, int ENUM)
        {
            
            return OleDbHelper.Fill("select * from " + TABEL + " WHERE " + filed4 + " = " + SID + " AND " + filed5 + " = " + EID + " AND " + filed6 + " = " + ENUM, "epiBySeriesTbl");
        }



        public static void UpdateUserBySubID(string name, int length, int series, int seasnenum, int epinum, int subid,string url)
        {
            // OleDbHelper.DoQuery("UPDATE UserTBL SET pass='" + pass + "', MyAdmin='" + MyAdmin + "',sub='" + sub + "' , email='" + email + "' WHERE username='" + username+ "'");
            name = stringbuilder(name);
            string length1 = stringbuilder(length.ToString());
            string series1 = stringbuilder(series.ToString());
            string seannum1 = stringbuilder(seasnenum.ToString());
            string epinum1 = stringbuilder(epinum.ToString());
            string id = stringbuilder(subid.ToString());
            url = stringbuilder(url);
            OleDbHelper.DoQuery("UPDATE " + TABEL + " SET " + filed2 + "=" + name + ", " + filed3 + "=" + length1 + ", " + filed4 + "=" + series1+ ", "+filed5+ "="+seannum1+", "+filed6+"="+epinum1+", "+filed7+"="+url+ " WHERE " + filed1 + "=" + subid.ToString());
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


        public static bool IsExistSeries(int SID,int EID, int ENUM)
        {

            DataSet ds = GetepiBySeries(SID,EID,ENUM);
            return (ds.Tables["epiBySeriesTbl"].Rows.Count > 0);


        }

    }
}
