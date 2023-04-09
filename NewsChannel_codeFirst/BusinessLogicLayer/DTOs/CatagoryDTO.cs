using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.DTOs
{
    public class CatagoryDTO
    {
        [Required]
        public int ID { set; get; }

        [Required]
        public string Name { set; get; }
    }
}
