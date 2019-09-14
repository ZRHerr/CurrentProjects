using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuickFix.Models
{
    public interface IServiceRepository
    {
        IEnumerable<Services> GetServices();

        Services GetServiceById(int serviceId);
    }
}
