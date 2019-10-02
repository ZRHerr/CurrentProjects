using System.Diagnostics;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
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

        public HomeIndexViewModel BuildHomeIndexModel()
        {
            var latest = _postService.GetLatestPosts(5);           
            var posts = latest.Select(post => new PostListingViewModel
            {
                Id = post.Id,
                Title = post.Title,
                AuthorName = post.User.UserName,
                AuthorId = post.User.Id,
                AuthorRating = post.User.Rating,
                DatePosted = post.Created.ToString(),
                RepliesCount = post.Replies.Count(),
                Forum = GetForumListingForPost(post)

            });
            return new HomeIndexViewModel
            {
                LatestPosts = posts,
            };

        }
        #region original code
        //var posts = new List<PostListingViewModel>();
        //foreach (var i in latestPosts)
        //{
        //    var pl = new PostListingViewModel
        //    {
        //        Id = i.Id,
        //        Title = i.Title,
        //        //Author = i.User.UserName,
        //        //AuthorId = i.User.Id,
        //        //AuthorRating = i.User.Rating,
        //        DatePosted = i.Created.ToString(),
        //        Forum = GetForumListingForPost(i)
        //    };
        //    posts.Add(pl);
        //}

        //var model = new HomeIndexViewModel();
        //model.LatestPosts = posts;
        //model.SearchQuery = string.Empty;
        //return model;
        #endregion
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
