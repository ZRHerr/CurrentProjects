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
    public class ReviewGroupController : Controller
    {
        IRepository<ReviewGroup> context;
        public ReviewGroupController(IRepository<ReviewGroup> reviewGroupContext)
        {
            context = reviewGroupContext;
        }
        // GET: ReviewManager
        public ActionResult Index()
        {
            List<ReviewGroup> reviewGroups = context.Collection().ToList();
            return View(reviewGroups);
        }
        public ActionResult Create()
        {
            ReviewGroup reviewGroup = new ReviewGroup();
            return View(reviewGroup);
        }

        [HttpPost]
        public ActionResult Create(ReviewGroup reviewGroup)
        {
            if (!ModelState.IsValid)
            {
                return View(reviewGroup);
            }
            else
            {
                context.Insert(reviewGroup);
                context.Commit();

                return RedirectToAction("Index");
            }
        }

        public ActionResult Edit(string Id)
        {
            ReviewGroup reviewGroup = context.Find(Id);
            if (reviewGroup == null)
            {
                return HttpNotFound();
            }
            else
            {
                return View(reviewGroup);
            }
        }

        [HttpPost]
        public ActionResult Edit(ReviewGroup reviewGroup, string Id)
        {
            ReviewGroup reviewGroupToEdit = context.Find(Id);
            if (reviewGroup == null)
            {
                return HttpNotFound();
            }
            else
            {
                if (!ModelState.IsValid)
                {
                    return View(reviewGroup);
                }
                reviewGroupToEdit.Rating = reviewGroup.Rating;

                context.Commit();

                return RedirectToAction("Index");
            }
        }

        public ActionResult Delete(string Id)
        {
            ReviewGroup reviewGroupToDelete = context.Find(Id);
            if (reviewGroupToDelete == null)
            {
                return HttpNotFound();
            }
            else
            {
                return View(reviewGroupToDelete);
            }
        }

        [HttpPost]
        [ActionName("Delete")]
        public ActionResult ConfirmDelete(string Id)
        {
            ReviewGroup reviewGroupToDelete = context.Find(Id);
            if (reviewGroupToDelete == null)
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