using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace NetflixDAL
{
    class Program
    {
        static void Main(string[] args)
        {

            // DataSet test = UserDAL.GetAll();
            //  SubScriptionTypeTBLDAL.Insert(7,7,"a");
            // UserDAL.Insert("razmaasdadshaSaat","1234",1,1,"rrr");
            //UserDAL.IsExist("razmashat");
            //  UserDAL.GetuserByID("razmashat");
            // UserDAL.UpdateUserByUsername("razmashat", "1234", 1, 1, "aaa");
            //Console.WriteLine(test.ToString());
            // SubScriptionTypeTBLDAL.GetAll();
            // SubScriptionTypeTBLDAL.GetSubByID(1);
            //SubScriptionTypeTBLDAL.UpdateUserByUsername("test", 3,2,1);
            // SeriesDAL.Insert("test",1,"coolstuff");
            //SeriesDAL.GetAll();
            //SeriesDAL.GetSubByID(1);
            // SeriesDAL.UpdateUserBySubID("coolstuff1",2,"test1",1);
            //  rateDAL.Insert("razmashat",1,5);
            // rateDAL.GetAll();
            // rateDAL.GetSubByID(4);
            //  rateDAL.UpdateRateByID("razmashat",3,1,4);
            //playlistDAL.Insert("razmashat");
            // playlistDAL.GetSubByID(1);
            //playlistDAL.GetAll();
            // playlistDAL.UpdatePlaylistByID( "razmashaSaat",1);
            // episodeDAL.Insert("test",1,1,1,1);
            //  episodeDAL.GetAll();
            //episodeDAL.GetepiByID(2);
            //episodeDAL.UpdateUserBySubID("test1",2,2,2,2,2);
            //     AdminDAL.Insert("test","124");
            // AdminDAL.GetAll();
            // AdminDAL.GetAdminByID(1);
            // AdminDAL.UpdateAdminBySubID("test1","11111111111111",1);
            //playlistandseriesDAL.Insert(1, 1);
            //  playlistandseriesDAL.Insert(2, 1);
            // DataSet ds =  playlistDAL.Innerjoin(2);
            //DataSet ds = SeriesDAL.Innerjoin(1);

            // SeriesAndUserDAL.Insert("razmashat",1);
            //  SeriesAndUserDAL.Insert("razmashat", 2);
            // DataSet ds= SeriesDAL.InnerjoinUser(2);
            DataSet ds = UserDAL.InnerjoinUser("razmashat");
            // playlistandseriesDAL.DelT(1,1);
            //  SeriesAndUserDAL.DelT("razmashat", 1);
            // bool f = SubScriptionTypeTBLDAL.IsExist(34);
            //  bool t = SubScriptionTypeTBLDAL.IsExist(1);
            // bool f = SeriesDAL.IsExist(13);
            //   bool t = SeriesDAL.IsExist(1);
            //  bool f = SeriesAndUserDAL.IsExist("razmashat", 1);
            // bool t = SeriesAndUserDAL.IsExist("razmashat", 2);
            //   bool t = rateDAL.IsExist(4);
            //   bool f = rateDAL.IsExist(42);
            // bool t = playlistDAL.IsExist(1);
            //   bool f = playlistDAL.IsExist(4);
            // bool t = episodeDAL.IsExist(1);
            //  bool f = episodeDAL.IsExist(43);
            //   bool t = AdminDAL.IsExist(1);
            //   bool f = AdminDAL.IsExist(34);
            //      bool t = playlistandseriesDAL.IsExist(1,2);
            //    bool f = playlistandseriesDAL.IsExist(3,3);
          //  DataSet ds = SeriesDAL.InnerjoinEpi(2);
            Console.ReadKey();
        }
    }
}
