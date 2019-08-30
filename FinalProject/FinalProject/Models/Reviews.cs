using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FinalProject.Models
{
    public class Reviews
    {
        [Key]
        public int ReviewId { get; set; }
        public int Rating { get; set; }
        public string Text { get; set; }
    }
}