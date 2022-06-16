using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Concrete
{
    public class SocialMedia
    {
        [Key]
        public int socialMediaId { get; set; }
        public string name { get; set; }
        public string url { get; set; }
        public string icon { get; set; }
        public bool status { get; set; }
    }
}
