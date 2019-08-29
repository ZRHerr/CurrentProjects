using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace FinalProject.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Required, MinLength(5), Index(IsUnique = true),Column(TypeName = "nvarchar")]
        public string Username { get; set; }

        [MinLength(5), Required, DataType(DataType.Password)]
        public string Password { get; set; }

        [EmailAddress, Index(IsUnique = true), Column(TypeName = "nvarchar"), Required]
        public string Email { get; set; }

        [Required, Column(TypeName ="nvarchar")]
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

        [ScaffoldColumn(false)]
        public string ImageUrl { get; set; }

        [ScaffoldColumn(false)]
        public DateTime? CreatedOn { get; set; }

    }
}