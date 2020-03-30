using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NetflixDAL;
using System.Data;

namespace NetflixBL
{
    public class Series
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
             GetEpisodes();
             

             
             
      }

        public int seriesID { get => SeriesID; set { } }
        public string seriesName { get => SeriesName; set { } }
        public int seriesAdmin { get => SeriesAdmin; set { } }
        public string Description { get => description; set { } }
        public List<Episode> Episodelist { get => episodelist; set { } }

        public void GetEpisodes()
        {
            DataSet ds = episodeDAL.GetEpiBySeriesID(SeriesID);
            for (int i = 0; i < ds.Tables["epiBySidTbl"].Rows.Count; i++)
            {
                episodelist.Add(new Episode(int.Parse(ds.Tables["epiBySidTbl"].Rows[i]["EpisdeID"].ToString())));
            }


        }


        public int GetWatchers()
        {

            DataSet ds = SeriesDAL.InnerjoinUser(SeriesID);
            return ds.Tables["uandstbl"].Rows.Count;
            

        }


        public static List<Series> GetAllSeries() 
        {
            List<Series> SeriesList = new List<Series>();
            DataSet ds = SeriesDAL.GetAll();
            for (int i = 0; i < ds.Tables["SeriesTBL"].Rows.Count; i++)
                SeriesList.Add(new Series(int.Parse(ds.Tables["SeriesTBL"].Rows[i]["SeriesID"].ToString())));
            return SeriesList;
        }


    }
}
