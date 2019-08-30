using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace FinalProject.Models
{
    public class Chat
    {
        [Key]       
        public int MessageId { get; set; }
        public string Subject { get; set; }
        public string Text { get; set; }
        public DateTime DateTime { get; set; }
    }
}