using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TrackerTemplate.Models
{
    public class ServiceBook
    {
        [Key]
        public int ServiceBookId { get; set; }

        [ForeignKey("ServiceBookLogId")]
        public int ServiceBookLogId { get; set; }

        [ForeignKey("Vehicle")]
        public int VehicleId { get; set; }

        public Vehicle Vehicle { get; set; }
        public ServiceBookLog ServiceBookLog { get; set; }
    }
}
