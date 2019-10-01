using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using System.Net.Http.Headers;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Authorization;
using Microsoft.Extensions.Configuration;
using MainProject.Data.Models;
using MainProject.Data;
using MainProject.Service;
using MainProject.Models;

namespace MainProject.Controllers
{
    public class ProfileController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IApplicationUser _userService;
        private readonly IConfiguration _configuration;

        public ProfileController(UserManager<ApplicationUser> userManager, IApplicationUser userService, IConfiguration configuration)
        {
            _userManager = userManager;
            _userService = userService;
            _configuration = configuration;
        }

        [Authorize]
        public IActionResult Detail(string id)
        {
            var user = _userService.GetById(id);
            var userRoles = _userManager.GetRolesAsync(user).Result;

            var model = new ProfileModel()
            {
                UserId = user.Id,
                Username = user.UserName,
                UserRating = user.Rating.ToString(),
                Email = user.Email,
                ProfileImageUrl = user.ProfileImageUrl,
                DateJoined = user.MemberSince,
                IsActive = user.IsActive,
                IsAdmin = userRoles.Contains("Admin")
            };

            return View(model);
        }

   
        public IActionResult Index()
        {
            var profiles = _userService.GetAll()
                .OrderByDescending(user => user.Rating)
                .Select(u => new ProfileModel
                {
                    Email = u.Email,
                    ProfileImageUrl = u.ProfileImageUrl,
                    UserRating = u.Rating.ToString(),
                    DateJoined = u.MemberSince,
                    IsActive = u.IsActive
                });

            var model = new ProfileListModel
            {
                Profiles = profiles
            };

            return View(model);
        }

        public IActionResult Deactivate(string userId)
        {
            var user = _userService.GetById(userId);
            _userService.Deactivate(user);
            return RedirectToAction("Index", "Profile");
        }
    }
}