using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Models
{
    public class Project
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Title { get; set;}

        [Required]
        public string Status { get; set;}

        [Required]
        public string StartDate { get; set;}

        [Required]
        public string EndDate { get; set;}

        public ICollection<Member> Members { get; set; }
        public Project()
        {
            Members = new List<Member>();
        }
    }
}
