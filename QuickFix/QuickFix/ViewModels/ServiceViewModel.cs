using QuickFix.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuickFix.ViewModels
{
    public class ServiceViewModel
    {
        public string Title { get; set; }
        public List<Services> services { get; set; }
    }
}
