using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Concrete
{
    public class Experience
    {
        [Key]
        public int experienceId { get; set; }    
        public string name { get; set; }    
        public string date { get; set; }    
        public string imageUrl { get; set; }    
        public string description { get; set; }    
    }
}
