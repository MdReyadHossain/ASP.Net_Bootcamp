using DataAccessLayer.Interface;
using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repos
{
    public class ProjectRepo : Repo, IProject<Project, int, string, bool>
    {
        public List<Project> Get()
        {
            return db.Projects.ToList();
        }

        public Project Get(int id)
        {
            return db.Projects.Find(id);
        }
        
        public Project Get(string status)
        {
            return db.Projects.Find(status);
        }

        public bool Create(Project prj)
        {
            db.Projects.Add(prj);
            return db.SaveChanges() > 0;
        }

        public bool Update(Project prj)
        {
            var project = Get(prj.Id);
            db.Entry(project).CurrentValues.SetValues(prj);
            return db.SaveChanges() > 0;
        }

        public bool Delete(int id)
        {
            var project = Get(id);
            db.Projects.Remove(project);
            return db.SaveChanges() > 0;
        }
    }
}
