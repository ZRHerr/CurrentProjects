using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyApp.Core.Contracts;
using MyApp.Core.Models;
using MyApp.Core.ViewModels;
using MyApp.DataAccess.InMemory;

namespace MyApp.WebUI.Controllers
{
    public class ServiceManagerController : Controller
    {
        IRepository<Service> context;
        IRepository<ServiceGroup> serviceGroups;
        public ServiceManagerController(IRepository<Service> serviceContext, IRepository<ServiceGroup> serviceGroupsContext)
        {           
            context = serviceContext;
            serviceGroups = serviceGroupsContext;
        }
        // GET: ServiceManager
        public ActionResult Index()
        {
            List<Service> Services = context.Collection().ToList();
            return View(Services);
        }
        public ActionResult Create()
        {
            ServiceManagerViewModel viewModel = new ServiceManagerViewModel();
            viewModel.Service = new Service();
            viewModel.ServiceGroups = serviceGroups.Collection();
            return View(viewModel);
        }

        [HttpPost]
        public ActionResult Create(Service Service)
        {
            if(!ModelState.IsValid)
            {
                return View(Service);
            }
            else
            {
                context.Insert(Service);
                context.Commit();

                return RedirectToAction("Index");
            }
        }

        public ActionResult Edit(string Id)
        {
            Service Service = context.Find(Id);
            if(Service == null)
            {
                return HttpNotFound();
            }
            else
            {
                ServiceManagerViewModel viewModel = new ServiceManagerViewModel();
                viewModel.Service = Service;
                viewModel.ServiceGroups = serviceGroups.Collection();
                return View(viewModel);
            }
        }

        [HttpPost]
        public ActionResult Edit(Service Service, string Id)
        {
            Service serviceToEdit = context.Find(Id);
            if (Service == null)
            {
                return HttpNotFound();
            }
            else
            {
                if(!ModelState.IsValid)
                {
                    return View(Service);
                }
                serviceToEdit.ServiceType = Service.ServiceType;
                serviceToEdit.ServiceDate = Service.ServiceDate;
                serviceToEdit.ServiceDetails = Service.ServiceDetails;

                context.Commit();

                return RedirectToAction("Index");
            }
        }

        public ActionResult Delete(string Id)
        {
            Service serviceToDelete = context.Find(Id);
            if (serviceToDelete == null)
            {
                return HttpNotFound();
            }
            else
            {
                return View(serviceToDelete);
            }
        }

        [HttpPost]
        [ActionName("Delete")]
        public ActionResult ConfirmDelete(string Id)
        {
            Service serviceToDelete = context.Find(Id);
            if (serviceToDelete == null)
            {
                return HttpNotFound();
            }
            else
            {
                context.Delete(Id);
                context.Commit();
                return RedirectToAction("Index");
            }

        }
    }
}