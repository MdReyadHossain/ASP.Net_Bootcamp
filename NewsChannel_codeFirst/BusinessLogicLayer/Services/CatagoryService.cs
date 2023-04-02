using DataAccessLayer.Models;
using DataAccessLayer.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Service
{
    public class CatagoryService
    {
        public static string CreateCatagory(Catagory catagory)
        {
            return CatagoryRepo.CreateCatagory(catagory);
        }
    }
}
