using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NetflixDAL;
using System.Data;

namespace NetflixBL
{
    public class General
    {


        public bool SignUp(string username,string pass,int adminid,int subtype,string email) {

            if (UserDAL.IsExist(username))
            {
                return false;
            }

            UserDAL.Insert(username,pass,adminid,subtype,email);
            return true;


        }


        public int Login(string username, string pass)
        {
            if (UserDAL.IsExist(username))
            {
                DataSet ds = UserDAL.GetuserByID(username);
                if (pass == ds.Tables["userByIdTbl"].Rows[0]["pass"].ToString())
                {
                    return 1;
                }
                return 0;
            }
            int result = -2;
            int.TryParse(username, out result);
            if (AdminDAL.IsExist(result))
            {
                DataSet ds = AdminDAL.GetAdminByID(result);
                if (pass == ds.Tables["adminByIdTbl"].Rows[0]["AdminPassword"].ToString())
                {
                    return 2;
                }
                return 0;
            }
            return 0;
        }




    }
}
