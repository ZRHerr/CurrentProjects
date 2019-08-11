using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PracticeASPNet.Models
{
    public class Segment
    {
        //ints
        public int Id { get; set; }
        public int TripId { get; set; }
        //strings
        public string Name { get; set; }
        public string Description { get; set; }
        //datetimes
        public DateTimeOffset StartDateTime { get; set; }

        public DateTimeOffset EndDateTime { get; set; }

        

    }
}
