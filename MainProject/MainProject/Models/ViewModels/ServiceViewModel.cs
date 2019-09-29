using MainProject.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MainProject.Models.ViewModels
{
    public class ServiceViewModel
    {
        public string Title { get; set; }
        public List<Services> Services { get; set; }
    }
}

