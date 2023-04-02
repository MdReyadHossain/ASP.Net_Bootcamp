using DataAccessLayer.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class NewsChannelContext : DbContext
    {
        public DbSet<Catagory> Catagories { set; get; }
        public DbSet<News> Newses { set; get; }
    }
}
