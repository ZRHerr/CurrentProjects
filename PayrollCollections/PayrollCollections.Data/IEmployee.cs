using System.Collections.Generic;
using System.Threading.Tasks;

namespace PayrollCollections.Data
{
    public interface IEmployee
    {
        Task Create(Employee employee);
        Task Delete(int id);
        Task Edit(int id);
        Employee GetById(int id);
        IEnumerable<Employee> GetAll();
        string GetPay(int id);
        string OverTime(int id);

    }
}
