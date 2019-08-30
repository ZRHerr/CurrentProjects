using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FinalProject.Models
{
    public class Services
    {
        [Key]
        public int ServiceId { get; set; }
        public string ServiceType { get; set; }
        public DateTime ServiceDate { get; set; }
        public DateTime CompletionDate { get; set; }
        public Guid? ServiceStatus { get; set; }
    }
}