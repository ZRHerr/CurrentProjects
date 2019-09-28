using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using QuickFix.Models;
using QuickFix.Models;

namespace QuickFix.Controllers
{
    public class HomeController : Controller
    {
        private static readonly UserInfo _LoggedOutUser = new UserInfo { IsAuthenticated = false };
        public readonly UserManager<AppUser> _UserManager;
        private readonly SignInManager<AppUser> _SignInManager;


        public HomeController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager)
        {
            _UserManager = userManager;
            _SignInManager = signInManager;
        }
        [HttpGet("user")]
        public async Task<UserInfo> GetUserAsync()
        {

            // TODO: Fetch the schedule id appropriately
            var theUser = await _UserManager.GetUserAsync(User);


            return User.Identity.IsAuthenticated
                    ? new UserInfo
                    {
                        Name = User.Identity.Name,
                        IsAuthenticated = true,
                        ScheduleId = theUser.ScheduleId.Value
                    }
          : _LoggedOutUser;
        }

        [HttpGet("user/signin")]
        public async Task SignInAsync(string redirectUri)
        {
            if (string.IsNullOrEmpty(redirectUri) || !Url.IsLocalUrl(redirectUri))
            {
                redirectUri = "/";
            }
            await HttpContext.ChallengeAsync(
                    new AuthenticationProperties { RedirectUri = redirectUri });

        }

        [HttpGet("user/signout")]
        public async Task<IActionResult> SignOutAsync()
        {
            await _SignInManager.SignOutAsync();
            return Redirect("~/");
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
