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


     public Rate (int ID)
     {

       
       DataSet ds = rateDAL.GetRateByID(ID);
       RateID = int.Parse(ds.Tables.Rows[0]["RateID"].ToString());
       Starts = int.Parse(ds.Tables.Rows[0]["Stars"].ToString());
       Author = ds.Tables.Rows[0]["Author"].ToString();
       EpisodeRated = int.Parse(ds.Tables.Rows[0]["EpisodeRated"].ToString());
   



     }

      

        

    }
}
