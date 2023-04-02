using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Models
{
    public class News
    {
        [Key]
        public int ID { set; get; }

        [Required]
        public string Title { set; get; }

        [Required]
        public string Description { set; get; }
        
        [ForeignKey("Catagory")]
        public int Cid { set; get; }
        public virtual Catagory Catagory { set; get; }

        [Required]
        public DateTime Date { set; get; }
    }
}
