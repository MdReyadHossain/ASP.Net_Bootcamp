using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Models
{
    public class Catagory
    {
        [Key]
        public int ID { set; get; }

        [Required]
        public string Name { set; get; }

        public virtual ICollection<News> Newses { set; get; }
        public Catagory()
        {
            Newses = new List<News>();
        } 
    }
}
