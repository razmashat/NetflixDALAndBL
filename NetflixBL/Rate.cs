using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NetflixDAL;
using System.Data;
namespace NetflixBL
{
   public class Rate
    {
 

     private int RateID;
     private int Starts;
     private string Author;
     private int EpisodeRated;


     public Rate (string username, int EpiID)
     {

      
        DataSet ds = rateDAL.GetRateByUser(username,EpiID);
       RateID = int.Parse(ds.Tables["rateByUserTbl"].Rows[0]["RateID"].ToString());
       Starts = int.Parse(ds.Tables["rateByUserTbl"].Rows[0]["Stars"].ToString());
       Author = ds.Tables["rateByUserTbl"].Rows[0]["Author"].ToString();
       EpisodeRated = int.Parse(ds.Tables["rateByUserTbl"].Rows[0]["EpisodeRated"].ToString());
   



     }

        public static bool IsExistUser(string username, int EpiID) 
        {
            return rateDAL.IsExistUser(username,EpiID);
        }
        //TODO: Maybe turn into int so i can understand which error happened
        public static bool DoRate(string username, int EpiID, int Stars) 
        {
            if (Stars > 5 || Stars < 1)
            {
                return false;
            }

            if (IsExistUser(username,EpiID))
            {
                return false;
            }
            rateDAL.Insert(username,EpiID,Stars);
            return true;

        }
        public int rateID { get => RateID; set { } }
        public int starts { get => Starts; set { } }
        public string author { get => Author; set { } }
        public int episodeRated { get => EpisodeRated; set { } }
    }
}
