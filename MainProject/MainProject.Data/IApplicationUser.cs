using MainProject.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MainProject.Data
{
    public interface IApplicationUser
    {
        ApplicationUser GetById(string id);

        IEnumerable<ApplicationUser> GetAll();
        Task IncrementRating(string id);
        Task Add(ApplicationUser user);
        Task Deactivate(ApplicationUser user);
        Task SetProfileImage(string id, Uri uri);
        Task BumpRating(string userId, Type type);
    }
}
