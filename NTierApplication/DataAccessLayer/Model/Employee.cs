using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Model
{
    public class Employee
    {
        [Key]
        public int ID { set; get; }

        [Required]
        [StringLength(50)]
        public string Name { set; get; }
    }
}
