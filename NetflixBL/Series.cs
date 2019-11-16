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

      public Series (int ID){



             DataSet ds = SeriesDAL.GetSeriesByID(ID);
             SeriesID = int.Parse(ds.Tables["seriesByIdTbl"].Rows[0]["SeriesID"].ToString());
             SeriesName = ds.Tables["seriesByIdTbl"].Rows[0]["SeriesName"].ToString();
             description = ds.Tables["seriesByIdTbl"].Rows[0]["description"].ToString();
             SeriesAdmin = int.Parse(ds.Tables["seriesByIdTbl"].Rows[0]["SeriesAdmin"].ToString());


             
             
      }


    }
}
