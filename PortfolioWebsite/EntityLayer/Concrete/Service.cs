using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Concrete
{
    public class Service
    {
        [Key]
        public int serviceId { get; set; }
        public string title { get; set; } 
        public string imageUrl { get; set; } 
    }
}
