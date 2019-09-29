using MainProject.Data;
using MainProject.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MainProject.Service.Repositories
{
    public class ServiceRepository : IServiceRepository
    {
        private readonly ApplicationDbContext _appDbContext;

        public ServiceRepository(ApplicationDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public Services GetServiceById(int serviceId)
        {
            return _appDbContext.Services.FirstOrDefault(s => s.Id == serviceId);
        }

        public IEnumerable<Services> GetServices()
        {
            return _appDbContext.Services;
        }
    }
}
