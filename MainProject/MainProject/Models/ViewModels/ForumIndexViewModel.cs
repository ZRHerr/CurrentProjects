using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MainProject.Models.ViewModels
{
    public class ForumIndexViewModel
    {
        public IEnumerable<ForumListingViewModel> ForumList { get; set; }
    }
}
