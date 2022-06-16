using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Concrete
{
    public class Testimonial
    {
        [Key]
        public int testimonialId { get; set; }
        public string clientName { get; set; }
        public string company { get; set; }
        public string comment { get; set; }
        public string imageUrl { get; set; }
    }
}
