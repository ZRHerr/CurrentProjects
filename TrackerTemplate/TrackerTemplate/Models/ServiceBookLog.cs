using System;
using System.ComponentModel.DataAnnotations;

namespace TrackerTemplate.Models
{
    public class ServiceBookLog
    {
        [Key]
        public int ServiceBookLogId { get; set; }
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }
        public float CurrentMileage { get; set; }
        public string CurrentFuelLevel { get; set; }
        public string ReturnFuelLevel { get; set; }
        [DataType(DataType.Date)]
        public DateTime EntryDate { get; set; }
        public float ReturnedMileage { get; set; }
        public string ServiceType { get; set; }
        public string Details { get; set; }
    }
}