using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using QuickFix.Models;
using QuickFix.ViewModels;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace QuickFix.Controllers
{
    public class ServiceController : Controller
    {
        private readonly IServiceRepository _serviceReposity;

        public ServiceController(IServiceRepository serviceRepository)
        {
            _serviceReposity = serviceRepository;
        }
        // GET: /<controller>/
        public IActionResult Index()
        {
            var services = _serviceReposity.GetServices().OrderBy(s => s.ServiceType);
            var serviceViewModel = new ServiceViewModel()
            {
                Title = "All active and past services",
                services = services.ToList()
            };
            return View(serviceViewModel);
        }
    }
}
