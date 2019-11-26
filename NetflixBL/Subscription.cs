using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NetflixDAL;
using System.Data;

namespace NetflixBL
{
    public class Subscription
    {


        private int SubscriptionID;
        private string description;
        private int amountpermonth;
        private int SeriesAmount;
        public int Seriesamount
        {
            get { return SeriesAmount; }
            set { }

        }


    public Subscription(int ID) {
        
     
      DataSet ds = SubScriptionTypeTBLDAL.GetSubByID(ID);
      SubscriptionID = int.Parse(ds.Tables["subByIdTbl"].Rows[0]["SubscriptionID"].ToString());
      description = ds.Tables["subByIdTbl"].Rows[0]["description"].ToString();
      amountpermonth = int.Parse(ds.Tables["subByIdTbl"].Rows[0]["amountpermonth"].ToString());
      SeriesAmount = int.Parse(ds.Tables["subByIdTbl"].Rows[0]["SeriesAmount"].ToString());
  

  



      } 
      
       }
}
