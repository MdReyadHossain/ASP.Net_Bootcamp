using BusinessLogicLayer.DTOs;
using DataAccessLayer;
using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Services
{
    public class ProjectServices
    {
        public static List<ProjectDTO> Get()
        {
            var data = DataAccessFactory.ProjectData().Get();
            return Convert(data);
        }

        public static bool Create(ProjectDTO prj)
        {
            var data = Convert(prj);
            return DataAccessFactory.ProjectData().Create(data);
        }

        public static ProjectDTO Get(int id)
        {
            return Convert(DataAccessFactory.ProjectData().Get(id));
        }

        public static ProjectDTO Get(string status)
        {
            return Convert(DataAccessFactory.ProjectData().Get(status));
        }

        static List<ProjectDTO> Convert(List<Project> prj)
        {
            var data = new List<ProjectDTO>();
            foreach (Project i in prj)
            {
                data.Add(Convert(i));
            }
            return data;
        }
        static ProjectDTO Convert(Project prj)
        {
            return new ProjectDTO()
            {
                Id = prj.Id,
                Title = prj.Title,
                Status = prj.Status,
                StartDate = prj.StartDate,
                EndDate = prj.EndDate
            };
        }
        static Project Convert(ProjectDTO prj)
        {
            return new Project()
            {
                Id = prj.Id,
                Title = prj.Title,
                Status = prj.Status,
                StartDate = prj.StartDate,
                EndDate = prj.EndDate
            };
        }
    }
}
