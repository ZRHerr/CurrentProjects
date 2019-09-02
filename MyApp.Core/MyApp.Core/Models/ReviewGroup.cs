using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Core.Models
{
    public class ReviewGroup
    {
        public string Id { get; set; }
        public string Rating { get; set; }

        public ReviewGroup()
        {
            this.Id = Guid.NewGuid().ToString();
        }
    }
}
