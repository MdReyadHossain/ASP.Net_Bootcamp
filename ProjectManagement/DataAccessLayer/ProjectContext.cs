using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class ProjectContext : DbContext
    {
        public DbSet<Member> Members { set; get; }
        public DbSet<Project> Projects { set; get; }
    }
}
