﻿using System;
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


        public bool Login(string username, string pass)
        {




        }




    }
}
