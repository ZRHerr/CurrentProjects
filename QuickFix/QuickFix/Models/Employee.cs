using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuickFix.Models
{
    public class Employee
    {
        public int EmpId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string StreetAddress1 { get; set; }
        public string StreetAddress2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string DriversLicense { get; set; }
        public decimal ContactNumber { get; set; }
        public string Email { get; set; }
        public string BusinessName { get; set; }
        public string BusinessUrl { get; set; }
        public byte[] Image { get; set; }
        public string BankName { get; set; }
        public string AccountType { get; set; }
        public int? AccountNumber { get; set; }
        public int? RoutingNumber { get; set; }
        public DateTime? DateCreated { get; set; }
    }
}
