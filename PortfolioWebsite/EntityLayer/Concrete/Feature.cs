using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Concrete
{
    public class Feature
    {
        [Key]
        public int featureId { get; set; }
        public string header { get; set; }
        public string name { get; set; }
        public string title { get; set; }
    }
}
