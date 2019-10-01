using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace MainProject.Models
{
    public class ProfileModel
    {
        public string UserId { get; set; }

        public string Email { get; set; }

        public string Username { get; set; }

        public string UserRating { get; set; }

        public string ProfileImageUrl { get; set; }

        public bool IsActive { get; set; }

        public bool IsAdmin { get; set; }



        public DateTime DateJoined { get; set; }

    }
}
