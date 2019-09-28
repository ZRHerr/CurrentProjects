using System;
using System.Collections.Generic;
using System.Text;

namespace MainProject.Data.Models
{
    public class Forum
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime CreatedOn { get; set; }
        public string ImageUrl { get; set; }

        public virtual IEnumerable<Post> Posts { get; set; }

    }
}
