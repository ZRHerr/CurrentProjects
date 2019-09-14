using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuickFix.Models
{
    public class MockServiceRepository : IServiceRepository
    {
        private List<Services> _services;

        public MockServiceRepository()
        {
            if(_services == null)
            {
                InitializeServices();
            }
        }

        private void InitializeServices()
        {
            _services = new List<Services>
            {
                new Services {Id = 1, ServiceType ="Oil Change", Description ="5W30 Full Synthetic", BasePrice = 32.95M},
                new Services {Id = 2, ServiceType ="Brake Pads", Description ="4 Pads 2 Rotors", BasePrice = 64.95M},
                new Services {Id = 3, ServiceType ="Alignment", Description ="Full Alignment with Tire Rotation", BasePrice = 42.95M},
                new Services {Id = 4, ServiceType ="Spark Plugs", Description ="6 plugs and 6 wires", BasePrice = 44.95M}
            };
        }

        public Services GetServiceById(int serviceId)
        {
            return _services.FirstOrDefault(s => s.Id == serviceId);
        }

        public IEnumerable<Services> GetServices()
        {
            return _services;
        }
    }
}
