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
    public class ReviewManagerController : Controller
    {
        IRepository<Review> context;
        IRepository<ReviewGroup> reviewGroups;
        public ReviewManagerController(IRepository<Review> reviewContext, IRepository<ReviewGroup> reviewGroupsContext)
        {           
            context = reviewContext;
            reviewGroups = reviewGroupsContext;
        }
        // GET: ReviewManager
        public ActionResult Index()
        {
            List<Review> reviews = context.Collection().ToList();
            return View(reviews);
        }
        public ActionResult Create()
        {
            ReviewManagerViewModel viewModel = new ReviewManagerViewModel();
            viewModel.Review = new Review();
            viewModel.ReviewGroups = reviewGroups.Collection();
            return View(viewModel);
        }

        [HttpPost]
        public ActionResult Create(Review review)
        {
            if(!ModelState.IsValid)
            {
                return View(review);
            }
            else
            {
                context.Insert(review);
                context.Commit();

                return RedirectToAction("Index");
            }
        }

        public ActionResult Edit(string Id)
        {
            Review review = context.Find(Id);
            if(review == null)
            {
                return HttpNotFound();
            }
            else
            {
                ReviewManagerViewModel viewModel = new ReviewManagerViewModel();
                viewModel.Review = review;
                viewModel.ReviewGroups = reviewGroups.Collection();
                return View(viewModel);
            }
        }

        [HttpPost]
        public ActionResult Edit(Review review, string Id)
        {
            Review reviewToEdit = context.Find(Id);
            if (review == null)
            {
                return HttpNotFound();
            }
            else
            {
                if(!ModelState.IsValid)
                {
                    return View(review);
                }
                reviewToEdit.Rating = review.Rating;
                reviewToEdit.Text = review.Text;

                context.Commit();

                return RedirectToAction("Index");
            }
        }

        public ActionResult Delete(string Id)
        {
            Review reviewToDelete = context.Find(Id);
            if (reviewToDelete == null)
            {
                return HttpNotFound();
            }
            else
            {
                return View(reviewToDelete);
            }
        }

        [HttpPost]
        [ActionName("Delete")]
        public ActionResult ConfirmDelete(string Id)
        {
            Review reviewToDelete = context.Find(Id);
            if (reviewToDelete == null)
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