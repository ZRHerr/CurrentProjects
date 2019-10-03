using PayrollCollections.Data;
using PayrollCollections.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PayrollCollections.Models
{
    public class EmployeeListingModel : Employee
    {
        public EmployeeService Services { get; set; }
        public IEnumerable<EmployeeService> AllServices { get; set; }
        public string OverTimePay { get;set; }
        public string TotalPay { get; set; }
    }
}
       
