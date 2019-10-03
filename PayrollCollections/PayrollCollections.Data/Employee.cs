using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace PayrollCollections.Data
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal RateOfPay { get; set; }
        public decimal Hours { get; set; }

        [DataType(DataType.Date)]
        public DateTime PayWeek { get; set; }

    }
}
