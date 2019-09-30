using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MainProject.Models.ViewModels
{
    public class HomeIndexViewModel
    {
        public IEnumerable<PostListingViewModel> LatestPosts { get; set; }
        public string SearchQuery { get; set; } //TODO search functionality
    }
}
