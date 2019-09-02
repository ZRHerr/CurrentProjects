using MyApp.Core.Contracts;
using MyApp.Core.Models;
using MyApp.DataAccess.InMemory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyApp.WebUI.Controllers
{
    public class ServiceGroupController : Controller
    {
        IRepository<ServiceGroup> context;
        public ServiceGroupController(IRepository<ServiceGroup> serviceGroupContext)
        {
            context = serviceGroupContext;
        }
        // GET: ServiceManager
        public ActionResult Index()
        {
            List<ServiceGroup> serviceGroups = context.Collection().ToList();
            return View(serviceGroups);
        }
        public ActionResult Create()
        {
            ServiceGroup serviceGroup = new ServiceGroup();
            return View(serviceGroup);
        }

        [HttpPost]
        public ActionResult Create(ServiceGroup serviceGroup)
        {
            if (!ModelState.IsValid)
            {
                return View(serviceGroup);
            }
            else
            {
                context.Insert(serviceGroup);
                context.Commit();

                return RedirectToAction("Index");
            }
        }

        public ActionResult Edit(string Id)
        {
            ServiceGroup serviceGroup = context.Find(Id);
            if (serviceGroup == null)
            {
                return HttpNotFound();
            }
            else
            {
                return View(serviceGroup);
            }
        }

        [HttpPost]
        public ActionResult Edit(ServiceGroup serviceGroup, string Id)
        {
            ServiceGroup serviceGroupToEdit = context.Find(Id);
            if (serviceGroup == null)
            {
                return HttpNotFound();
            }
            else
            {
                if (!ModelState.IsValid)
                {
                    return View(serviceGroup);
                }
                serviceGroupToEdit.ServiceType = serviceGroup.ServiceType;

                context.Commit();

                return RedirectToAction("Index");
            }
        }

        public ActionResult Delete(string Id)
        {
            ServiceGroup serviceGroupToDelete = context.Find(Id);
            if (serviceGroupToDelete == null)
            {
                return HttpNotFound();
            }
            else
            {
                return View(serviceGroupToDelete);
            }
        }

        [HttpPost]
        [ActionName("Delete")]
        public ActionResult ConfirmDelete(string Id)
        {
            ServiceGroup serviceGroupToDelete = context.Find(Id);
            if (serviceGroupToDelete == null)
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