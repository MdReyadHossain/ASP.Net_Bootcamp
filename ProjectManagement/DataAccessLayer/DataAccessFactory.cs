using DataAccessLayer.Interface;
using DataAccessLayer.Models;
using DataAccessLayer.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class DataAccessFactory
    {
        public static IMember<Member, int, bool> MemberData()
        {
            return new MemberRepo();
        }
        
        public static IProject<Project, int, string, bool> ProjectData()
        {
            return new ProjectRepo();
        }

    }
}
