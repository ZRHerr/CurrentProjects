using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PayrollCollections.Models
{
    public class EmployeeViewModel
    {
        public int NumberOfEmployees { get; set; }
        public IEnumerable<EmployeeListingModel> EmpList { get; set; }
        public IEnumerable<Services.EmployeeService> ServiceList { get; set; }
    }
}
