using DataAccessLayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repo
{
    public class EmpRepo
    {
        static EmpContext db;

        static EmpRepo()
        {
            db = new EmpContext();
        }

        public static List<Employee> Get()
        {
            return db.Employees.ToList();
        }

        public static Employee Get(int id)
        {
            return db.Employees.Find(id);
        }

        public bool Create(Employee emp)
        {
            db.Employees.Add(emp);
            return db.SaveChanges() > 0;
        }

        public bool Update(Employee emp)
        {
            var employeeDB = Get(emp.ID);
            db.Entry(employeeDB).CurrentValues.SetValues(emp);
            return db.SaveChanges() > 0;
        }
        
        public bool Delete(int id)
        {
            var employeeDB = Get(id);
            db.Employees.Remove(employeeDB);
            return db.SaveChanges() > 0;
        }
    }
}
