using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TrackerTemplate.Models
{
    public class Vehicle
    {
        public int VehicleId { get; set; }

        public int GetVehicleId()
        {
            return VehicleId;
        }

        public void SetVehicleId(int value)
        {
            VehicleId = value;
        }

        [Required]
        public string Brand { get; set; }

        [Required]
        public string Model { get; set; }
        public string Color { get; set; }
        public string ProductionYear { get; set; }
        public string LicensePlate { get; set; }
        public string Owner { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime PurchaseDate { get; set; }
        [Required]
        public int Mileage { get; set; }
        public string Image { get; set; }
        [ForeignKey("dbo.AspNetUsers")]
        public string UserId { get; set; }
        public ICollection<ServiceBook> ServiceBooks { get; set; }
    }
}
