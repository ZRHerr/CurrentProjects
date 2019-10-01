using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MainProject.Data.Models;
using MainProject.Models.ViewModels;
using MainProject.Service.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace MainProject.Controllers
{
    public class ForumController : Controller
    {
        private readonly IForum _forumService;
        //private readonly IPost _postService;
        //Dependency Injection by using Interfaces.
        public ForumController(IForum forumService)
        {
            _forumService = forumService;
        }

        public IActionResult Index()
        {
            var forums = _forumService.GetAll()
                .Select(forum => new ForumListingViewModel {
                    Id = forum.Id,
                    Name = forum.Title,
                    Description = forum.Description,           
            });
            var model = new ForumIndexViewModel {
                ForumList = forums
            };

            return View(model);
        }

        public IActionResult Topic(int id)
        {
            var forum = _forumService.GetById(id);
            var posts = forum.Posts;
            var postListings = posts.Select(post => new PostListingViewModel
            {
                Id = post.Id,
                AuthorId = post.User.Id,
                AuthorName = post.User.UserName,
                AuthorRating = post.User.Rating,
                Title = post.Title,
                DatePosted = post.Created.ToString(),
                RepliesCount=post.Replies.Count(),
                Forum = BuildForumListing(post)
            });
            var model = new ForumTopicViewModel
            {
                Posts = postListings,
                Forum = BuildForumListing(forum)
            };

            return View(model);

        }

        private ForumListingViewModel BuildForumListing(Post post)
        {
            var forum = post.Forum;
           return BuildForumListing(forum);

        }
        private ForumListingViewModel BuildForumListing(Forum forum)
        {           
            return new ForumListingViewModel
            {
                Id = forum.Id,
                Name = forum.Title,
                Description = forum.Description,
                ImageUrl = forum.ImageUrl

            };
        }
    }
}