using MyApp.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Core.ViewModels
{
    public class ReviewManagerViewModel
    {
        public Review Review { get; set; }
        public IEnumerable<ReviewGroup> ReviewGroups { get; set; }
    }
}
