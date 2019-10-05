using System.Diagnostics;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using TrackerTemplate.Models;
using TrackerTemplate.Models.AccountViewModels;

namespace TrackerTemplate.Controllers
{

    public class DashboardController : Controller
    {
        private readonly UserManager<AppUser> userManager;

        public DashboardController(UserManager<AppUser> userManager)
        {
            this.userManager = userManager;
        }

        // Dashboard
        public IActionResult Index()
        {
            var currentUserId = userManager.GetUserId(User);

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
