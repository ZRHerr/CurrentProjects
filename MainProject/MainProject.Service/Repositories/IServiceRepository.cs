using MainProject.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MainProject.Service.Repositories
{
    public interface IServiceRepository
    {
        IEnumerable<Services> GetServices();

        Services GetServiceById(int serviceId);
    }
}
