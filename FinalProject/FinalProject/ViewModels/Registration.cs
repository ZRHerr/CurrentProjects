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
        //The passwords should be compared to ensure password creation is what the user intended
        [Required, MinLength(5)]
        public string Username { get; set; }

        [MinLength(5), Required, DataType(DataType.Password)]
        public string Password { get; set; }

        [Compare("Password", ErrorMessage = "Passwords did not match"), DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }

        [EmailAddress, Required]
        public string Email { get; set; }

    }
}