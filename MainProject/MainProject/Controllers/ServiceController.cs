using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MainProject.Data.Models;
using MainProject.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace MainProject.Controllers
{
    public class ServiceController : Controller
    {
        private readonly IServiceRepository _serviceRepository;

        public ServiceController(IServiceRepository serviceRepository)
        {
            _serviceRepository = serviceRepository;
        }
        // GET: /<controller>/
        public IActionResult Index()
        {
            var services = _serviceRepository.GetServices().OrderBy(s => s.ServiceType);
            var serviceViewModel = new ServiceViewModel()
            {
                Title = "All pending services",
                Services = services.ToList()
            };
            return View(serviceViewModel);
        }
        public IActionResult Details(int id)
        {
            var services = _serviceRepository.GetServiceById(id);
            if (services == null)
                return NotFound();

            return View(services);
        }
    }
}