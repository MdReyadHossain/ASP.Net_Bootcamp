using DataAccessLayer.Model;
using DataAccessLayer.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Service
{
    public class EmpService
    {
        public static object Get()
        {
            return EmpRepo.Get();
        }

        public static Employee Get(int id)
        {
            return EmpRepo.Get(id);
        }

        public static bool Create(Employee emp)
        {
            return EmpRepo.Create(emp);
        }

        public static bool Update(Employee emp)
        {
            return EmpRepo.Update(emp);
        }

        public static bool Delete(int id)
        {
            return EmpRepo.Delete(id);
        }
    }
}
