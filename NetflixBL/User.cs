using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NetflixDAL;
using System.Data;

namespace NetflixBL
{
    public class User
    {
        private string username;
        private string pass;
        private int MyAdmin;
        private int subscriptiontype;
        private string email;

        public User (string ID){

            DataSet ds = UserDAL.GetuserByID(ID);
            username = ds.Tables["adminByIdTbl"].Rows[0]["username"].ToString();
            pass = ds.Tables["adminByIdTbl"].Rows[0]["pass"].ToString();
            subscriptiontype = int.Parse(ds.Tables["adminByIdTbl"].Rows[0]["subscriptiontype"].ToString());
            MyAdmin = int.Parse(ds.Tables["adminByIdTbl"].Rows[0]["MyAdmin"].ToString());
            email = ds.Tables["adminByIdTbl"].Rows[0]["email"].ToString();
            

        }
    }
}
