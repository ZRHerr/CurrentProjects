using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FinalProject.Models
{
    public class Vehicles
    {
        [Key]
        public int VehicleId { get; set; }
        public int Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public DateTime RegistrationExp { get; set; }
        public string PolicyNum { get; set; }
    }
}