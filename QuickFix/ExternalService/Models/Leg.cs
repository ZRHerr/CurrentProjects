using System;
using System.Collections.Generic;
using System.Text;

namespace ExternalService.Models
{
    public class Leg
    {
        public List<Step> Steps { set; get; }
        public Pair Duration { set; get; }
        public Pair Distance { set; get; }
        public Point Start_location { set; get; }
        public Point End_location { set; get; }

    }
}
