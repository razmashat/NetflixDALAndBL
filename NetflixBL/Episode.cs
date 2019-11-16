using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NetflixDAL;
using System.Data;

namespace NetflixBL
{
   public class Episode
    {
        private int EpisdeID;
        private string EpisodeName;
        private int EpisodeLength;
        private int EpiSeries;
        private int SeasonNum;
        private int EpiNum;


        public Episode (int ID) 
        {
            DataSet ds = episodeDAL.GetepiByID(ID);
            EpisdeID = int.Parse(ds.Tables["epiByIdTbl"].Rows[0]["EpisdeID"].ToString());
            EpisodeName = ds.Tables["epiByIdTbl"].Rows[0]["EpisodeName"].ToString();
            EpisodeLength = int.Parse(ds.Tables["epiByIdTbl"].Rows[0]["EpisodeLength"].ToString());
            EpiSeries = int.Parse(ds.Tables["epiByIdTbl"].Rows[0]["EpiSeries"].ToString());
            SeasonNum = int.Parse(ds.Tables["epiByIdTbl"].Rows[0]["SeasonNum"].ToString());
            EpiNum = int.Parse(ds.Tables["epiByIdTbl"].Rows[0]["EpiNum"].ToString());
            
            
        }
    }
}
