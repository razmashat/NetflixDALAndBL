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


        private int subscriptionID;
        private string description;
        private int amountpermonth;
        private int SeriesAmount;
        public int Seriesamount
        {
            get { return SeriesAmount; }
            set { }

        }

        public string Description { get => description; set => description = value; }
        public int SubscriptionID { get => subscriptionID; set => subscriptionID = value; }
        public int Amountpermonth { get => amountpermonth; set { } }

        public Subscription(int ID) {
        
     
      DataSet ds = SubScriptionTypeTBLDAL.GetSubByID(ID);
      SubscriptionID = int.Parse(ds.Tables["subByIdTbl"].Rows[0]["SubscriptionID"].ToString());
      description = ds.Tables["subByIdTbl"].Rows[0]["description"].ToString();
      amountpermonth = int.Parse(ds.Tables["subByIdTbl"].Rows[0]["amountpermonth"].ToString());
      SeriesAmount = int.Parse(ds.Tables["subByIdTbl"].Rows[0]["SeriesAmount"].ToString());
  

  



      }

        public static List<Subscription> GetAllSubs() 
        {

            List<Subscription> SubsList = new List<Subscription>();
            DataSet ds = SubScriptionTypeTBLDAL.GetAll();
            for (int i = 0; i < ds.Tables["SubScriptionTypeTBL"].Rows.Count; i++)
                SubsList.Add(new Subscription(int.Parse(ds.Tables["SubScriptionTypeTBL"].Rows[i]["SubscriptionID"].ToString())));
            return SubsList;
        
        }
      
       }
}
