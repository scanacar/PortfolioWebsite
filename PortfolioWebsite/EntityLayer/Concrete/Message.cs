using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Concrete
{
    public class Message
    {
        [Key]
        public int messageId { get; set; } 
        public string senderName { get; set; } 
        public string senderMail { get; set; } 
        public string content { get; set; } 
        public DateTime date { get; set; } 
        public bool status { get; set; } 
    }
}
