using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Core.Models
{
    public class Service : BaseEntity
    {
       
        public string ServiceType { get; set; }
        public DateTime ServiceDate { get; set; }
        public string ServiceDetails { get; set; }
        public DateTime CompletionDate { get; set; }
    }
}
