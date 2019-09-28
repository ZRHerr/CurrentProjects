using System;
using System.Collections.Generic;
using System.Text;

namespace MainProject.Data.Models
{
    public class Services
    {
        public int Id { get; set; }
        public string ServiceType { get; set; }
        public String ServiceStatus { get; set; }
        public string Description { get; set; }
        public decimal BasePrice { get; set; }
        public DateTime ServiceDate { get; set; }
        public DateTime CompletionDate { get; set; }
        public bool IsServiceDiscount { get; set; }
        public bool IsComplete { get; set; }
    }
}
