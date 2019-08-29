using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace FinalProject.ViewModels
{
    public class Registration
    {
        //This data doesnt need to be compared with the data within the database
        
        [Required, MinLength(5)]
        public string Username { get; set; }

        //The passwords should be compared to ensure password creation is what the user intended
        [MinLength(5), Required, DataType(DataType.Password)]
        public string Password { get; set; }

        [Compare("Password", ErrorMessage = "Passwords did not match"), DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }

        [EmailAddress, Required]
        public string Email { get; set; }

        [Required, Column(TypeName = "nvarchar")]
        public string FirstName { get; set; }

        [Required, Column(TypeName = "nvarchar")]
        public string LastName { get; set; }

        [Required, Column(TypeName = "nvarchar")]
        public string StreetAddress { get; set; }

        [Required, Column(TypeName = "nvarchar")]
        public string City { get; set; }

        [Required, Column(TypeName = "nvarchar")]
        public string State { get; set; }

        [Required, Column(TypeName = "nvarchar")]
        public string ZipCode { get; set; }

        [Required, Column(TypeName = "nvarchar")]
        public string ContactNumber { get; set; }
    }
}