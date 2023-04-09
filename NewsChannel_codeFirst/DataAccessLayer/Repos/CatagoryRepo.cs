using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repos
{
    public class CatagoryRepo
    {
        static NewsChannelContext news;

        static CatagoryRepo()
        {
            news = new NewsChannelContext();
        }

        public static List<Catagory> GetCatagories()
        {
            return news.Catagories.ToList();
        }

        public static Catagory GetCatagories(int id)
        {
            return news.Catagories.Find(id);
        }

        public static bool CreateCatagory(Catagory catagory)
        {
            var db = news.Catagories.Find(catagory.Name);
            // Console.WriteLine(db);
            // return null;

            news.Catagories.Add(catagory);
            return news.SaveChanges() > 0;
            // if (news.SaveChanges() > 0)
            // return "Catagory has been created!";
        }
    }
}
