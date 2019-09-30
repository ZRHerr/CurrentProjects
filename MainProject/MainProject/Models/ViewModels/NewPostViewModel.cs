﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MainProject.Models.ViewModels
{
    public class NewPostViewModel
    {
        public string ForumName { get; set; }
        public int ForumId { get; set; }
        public string AuthorName { get; set; }
        public string ForumImageUrl { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
    }
}
