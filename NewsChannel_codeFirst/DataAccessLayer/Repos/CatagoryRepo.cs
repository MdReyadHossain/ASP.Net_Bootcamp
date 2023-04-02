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

        public static string CreateCatagory(Catagory catagory)
        {
            news.Catagories.Find(catagory.Name);
            news.Catagories.Add(catagory);
            if (news.SaveChanges() > 0)
                return "Catagory has been created!";

            else
                return "No";
        }
    }
}
