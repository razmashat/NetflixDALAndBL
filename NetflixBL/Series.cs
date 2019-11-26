using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NetflixDAL;
using System.Data;

namespace NetflixBL
{
    class Series
    {


        private int SeriesID;
        private string SeriesName;
        private int SeriesAdmin;
        private string description;
        private List<Episode> episodelist;

      public Series (int ID){



             DataSet ds = SeriesDAL.GetSeriesByID(ID);
             SeriesID = int.Parse(ds.Tables["seriesByIdTbl"].Rows[0]["SeriesID"].ToString());
             SeriesName = ds.Tables["seriesByIdTbl"].Rows[0]["SeriesName"].ToString();
             description = ds.Tables["seriesByIdTbl"].Rows[0]["description"].ToString();
             SeriesAdmin = int.Parse(ds.Tables["seriesByIdTbl"].Rows[0]["SeriesAdmin"].ToString());
             episodelist = new List<Episode>();
             

             
             
      }


        public void GetEpisodes()
        {
            DataSet ds = episodeDAL.GetEpiBySeriesID(SeriesID);
            for (int i = 0; i < ds.Tables["epiBySidTbl"].Rows.Count; i++)
            {
                episodelist.Add(new Episode(int.Parse(ds.Tables["epiBySidTbl"].Rows[i]["EpisdeID"].ToString())));
            }


        }


    }
}
