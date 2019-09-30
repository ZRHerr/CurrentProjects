using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MainProject.Models;
using MainProject.Models.ViewModels;
using MainProject.Data.Models;

namespace MainProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly IPost _postService;
        public HomeController(IPost postService)
        {
            _postService = postService;
        }
        public IActionResult Index()
        {
            var model = BuildHomeIndexModel();
            return View(model);
        }

        private HomeIndexViewModel BuildHomeIndexModel()
        {
            var latestPosts = _postService.GetLatestPosts(5);

            var posts = latestPosts.Select(post => new PostListingViewModel
            {
                Id = post.Id,
                Title = post.Title,
                Author = post.User.UserName,
                AuthorId = post.User.Id,
                AuthorRating = post.User.Rating,
                DatePosted = post.Created.ToString(),
                Forum = GetForumListingForPost(post)

            });
            return new HomeIndexViewModel
            {
                LatestPosts = posts,
                SearchQuery = ""
            };
        }

        private ForumListingViewModel GetForumListingForPost(Post post)
        {
            var forum = post.Forum;
            return new ForumListingViewModel
            {
                Id = forum.Id,
                Name = forum.Title,
                ImageUrl = forum.ImageUrl               
            };
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
