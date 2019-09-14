using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuickFix.Models
{
    public class Customer
    {
        public int CustId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string StreetAddress1 { get; set; }
        public string StreetAddress2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public decimal ContactNumber { get; set; }
        public string Email { get; set; }
        public byte[] Image { get; set; }
        public DateTime? DateCreated { get; set; }
    }
}
