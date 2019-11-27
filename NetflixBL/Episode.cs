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
        private string EpiURL;
        private List<Rate> Rates;

        public int episdeID { get => EpisdeID; set { } }
        public string episodeName { get => EpisodeName; set { } }
        public int episodeLength { get => EpisodeLength; set { } }
        public int epiSeries { get => EpiSeries; set { } }
        public int seasonNum { get => SeasonNum; set { } }
        public int epiNum { get => EpiNum; set { } }
        public string epiURL { get => EpiURL; set { } }
        public List<Rate> rates { get => Rates; set { } }

        public double avgrate { get { return AvgRate(); } set { } }

        public Episode (int ID) 
        {
            DataSet ds = episodeDAL.GetepiByID(ID);
            EpisdeID = int.Parse(ds.Tables["epiByIdTbl"].Rows[0]["EpisdeID"].ToString());
            EpisodeName = ds.Tables["epiByIdTbl"].Rows[0]["EpisodeName"].ToString();
            EpisodeLength = int.Parse(ds.Tables["epiByIdTbl"].Rows[0]["EpisodeLength"].ToString());
            EpiSeries = int.Parse(ds.Tables["epiByIdTbl"].Rows[0]["EpiSeries"].ToString());
            SeasonNum = int.Parse(ds.Tables["epiByIdTbl"].Rows[0]["SeasonNum"].ToString());
            EpiNum = int.Parse(ds.Tables["epiByIdTbl"].Rows[0]["EpiNum"].ToString());
            Rates = new List<Rate>();
            GetRates();
            
            
        }

        public void GetRates()
        {

            DataSet ds = rateDAL.GetRateByEpisode(EpisdeID);
            for (int i = 0; i < ds.Tables["rateByEpiTbl"].Rows.Count; i++)
            {
                Rates.Add(new Rate(int.Parse(ds.Tables["rateByEpiTbl"].Rows[i]["RateID"].ToString())));
            }

        }

            public double AvgRate()
        {

            double avgrate = 0;
            for (int i = 0; i < Rates.Count; i++)
            {
                avgrate += Rates[i].starts;
            }
            avgrate = avgrate / Rates.Count;
            return avgrate;

        }

    }
}
