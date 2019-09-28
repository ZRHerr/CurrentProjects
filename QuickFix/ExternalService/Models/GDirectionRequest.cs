using System;
using System.Collections.Generic;
using System.Text;

namespace ExternalService.Models
{
    public class GDirectionRequest
    {
        public GDirectionRequest()
        {
            Src = new Point();
            Dst = new Point();
            WayPoints = new List<Point>();
        }

        public Point Src { set; get; }
        public Point Dst { set; get; }
        public List<Point> WayPoints { set; get; }

    }
}
