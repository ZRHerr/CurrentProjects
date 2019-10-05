using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using TrackerTemplate.Models;
using TrackerTemplate.Models.AccountViewModels;

namespace TrackerTemplate.Controllers
{
    public class FuelCalculatorController : Controller
    {
        private readonly UserManager<AppUser> userManager;

        public FuelCalculatorController(UserManager<AppUser> userManager)
        {
            this.userManager = userManager;
        }

        public IActionResult Index(FuelCalculator model)
        {
            var currentUserId = userManager.GetUserId(User);

            return View();
        }
    }
}