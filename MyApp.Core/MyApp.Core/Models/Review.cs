using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Core.Models
{
    public class Review : BaseEntity
    {
        [Range(0,5)]
        public string Rating { get; set; }
        public string Text { get; set; }
    }
}
