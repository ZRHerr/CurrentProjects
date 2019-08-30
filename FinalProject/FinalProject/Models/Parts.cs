using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;


namespace FinalProject.Models
{
    public class Parts
    {
        [Key]
        public int Partid { get; set; }
        public string PartName { get; set; }
        public decimal UnitPrice { get; set; }
        public int Qty { get; set; }
    }
}