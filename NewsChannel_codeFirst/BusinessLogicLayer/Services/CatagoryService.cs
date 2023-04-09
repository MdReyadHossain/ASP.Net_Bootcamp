using BusinessLogicLayer.DTOs;
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
        public static bool CreateCatagory(CatagoryDTO catagory)
        {
            var data = Convert(catagory);
            return CatagoryRepo.CreateCatagory(data);
        }

        static Catagory Convert(CatagoryDTO catagory)
        {
            return new Catagory()
            {
                ID = catagory.ID,
                Name = catagory.Name
            };
        }
    }
}
