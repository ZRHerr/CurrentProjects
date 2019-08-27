using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace FinalProject.Models
{
    public class Message
    {
        [Key]
        public int MessageId { get; set; }

        [Required]
        public string Text { get; set; }

        public int UserId { get; set; }

        [ForeignKey("UserId")]

        public virtual User User { get; set; }

        public Collection<Reply> Replies { get; set; }
    }
}
