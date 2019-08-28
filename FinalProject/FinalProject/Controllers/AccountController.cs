using FinalProject.Models;
using FinalProject.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FinalProject.Controllers
{
    public class AccountController : Controller
    {
        private ApplicationDBContent db = new ApplicationDBContent();
        [HttpGet]
        public ActionResult Register()
        {
            return View();
        }
        //Validating that the user information does not already exist
        [HttpPost]
        public ActionResult Register(Registration obj)
        {
            bool UserExists = db.Users.Any(x => x.Username == obj.Username);
            if (UserExists)
            {
                ViewBag.UsernameMessage = "This username is already in use, try another";
                return View();
            }
            bool EmailExists = db.Users.Any(y => y.Email == obj.Email);
            if (EmailExists)
            {
                ViewBag.EmailMessage = "This Email is already in use, try another";
            }

            //If the username and email are unique, the registered user will then be saved.

            User u = new User();

            u.Username = obj.Username;
            u.Password = obj.Password;
            u.Email = obj.Email;
            u.ImageUrl = "";
            u.CreatedOn = DateTime.Now;


            db.Users.Add(u);
            db.SaveChanges();
            return RedirectToAction("Index", "Home");

        }
        public ActionResult Login()
        {
            Account account = new Account();
            return View(account);
        }
        //Validating the Login information to ensure it exists in the database or will display error
        [HttpPost]
        public ActionResult Login(Account obj)
        {
            if (ModelState.IsValid)
            {
                if (db.Users.Where(m => m.Username == obj.Username && m.Password == obj.Password).FirstOrDefault() == null)
                {
                    ModelState.AddModelError("Error", "Invalid Entries");
                    return View();
                }
                else
                {
                    Session["Username"] = obj.Username;
                }
            }
            return RedirectToAction("Index", "Home");
        }
        public ActionResult Logout()
        {
            Session.Abandon();
            return RedirectToAction("Index","Home");
        }
    }
}