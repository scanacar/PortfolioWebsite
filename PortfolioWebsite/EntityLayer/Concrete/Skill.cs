using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Concrete
{
    public class Skill
    {
        [Key]
        public int skillId { get; set; }
        public string title { get; set; }
        public string value { get; set; }
    }
}
