using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PracticeASPNet.Models
{
    public class Repository
    {

        private List<Trip> MyTrips = new List<Trip>
        {
            new Trip
            {
                Id = 1,
                Name = "MSSA interviews",
                StartDate = new DateTime(2019, 10, 24),
                EndDate = new DateTime(2019, 10, 27)
            },
            new Trip
            {
                Id = 2,
                Name = "Amazon interviews",
                StartDate = new DateTime(2019, 10, 28),
                EndDate = new DateTime(2019, 10, 29)
            }
        };
        public List<Trip> Get()
        {
            return MyTrips;
        }

        public void Add(Trip newTrip)
        {
            MyTrips.Add(newTrip);
        }
        public void Update(Trip tripToUpdate)
        {
            MyTrips.Remove(MyTrips.First(t => t.Id == tripToUpdate.Id));
            Add(tripToUpdate);
        }
        public void Remove(int id)
        {
            MyTrips.Remove(MyTrips.First(t => t.Id == id));
        }
    }
}

