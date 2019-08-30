using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FinalProject.ViewModels
{
    public class Registration
    {
        [Key]
        [Required]
        public int CustId { get; set; }
        //This data doesnt need to be compared with the data within the database
        [Required]
        public string UserName { get; set; }

        //The passwords should be compared to ensure password creation is what the user intended
        [Required, DataType(DataType.Password)]
        public string Password { get; set; }

        [Compare("Password", ErrorMessage = "Passwords did not match"), DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }

        [EmailAddress, Required]
        public string Email { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public string StreetAddress1 { get; set; }

        [Required]
        public string StreetAddress2 { get; set; }

        public string City { get; set; }

        [Required]
        public string State { get; set; }

        [Required]
        public string Zip { get; set; }

        [Required]
        public decimal ContactNumber { get; set; }
    }
}