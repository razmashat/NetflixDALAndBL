using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NetflixDAL;
using System.Data;

namespace NetflixBL
{
    public class Admin
    {
        private int AdminID;
        private string AdminName;
        private string AdminPassword;

        public Admin(int ID) {
            DataSet ds = AdminDAL.GetAdminByID(ID);
            AdminID = int.Parse(ds.Tables["adminByIdTbl"].Rows[0]["AdminID"].ToString());
            AdminName = ds.Tables["adminByIdTbl"].Rows[0]["AdminName"].ToString();
            AdminPassword = ds.Tables["adminByIdTbl"].Rows[0]["AdminPassword"].ToString();

        }
    }
}
