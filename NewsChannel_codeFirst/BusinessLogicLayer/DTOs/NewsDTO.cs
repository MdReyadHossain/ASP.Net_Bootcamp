using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.DTOs
{
    public class NewsDTO
    {
        [Required]
        public int ID { set; get; }

        [Required]
        public string Title { set; get; }

        [Required]
        public string Description { set; get; }

        [Required]
        public int Cid { set; get; }

        [Required]
        public DateTime Date { set; get; }
    }
}
