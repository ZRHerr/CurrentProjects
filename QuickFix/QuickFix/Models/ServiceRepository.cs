using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using QuickFix.Models;

namespace QuickFix.Models
{
    public class ServiceRepository : IServiceRepository
    {
        private readonly AppDbContext _appDbContext;

        public ServiceRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public Services GetServiceById(int serviceId)
        {
            return _appDbContext.services.FirstOrDefault(s => s.Id == serviceId);
        }

        public IEnumerable<Services> GetServices()
        {
            return _appDbContext.services;
        }
    }
}
