using PayrollCollections.Data;
using PayrollCollections.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PayrollCollections.Services
{
    public class EmployeeService : IEmployee
    {
        private readonly ApplicationDbContext _context;

        public EmployeeService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task Create(Employee newEmp)
        {
            _context.Add(newEmp);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var emp = GetById(id);
            _context.Remove(emp);
            await _context.SaveChangesAsync();
        }
        public async Task Edit(int id)
        {
            var emp = GetById(id);
            _context.Update(emp);
            await _context.SaveChangesAsync();
        }
        public IEnumerable<Employee> GetAll()
        {
            return _context.Employees;
        }

        public Employee GetById(int id)
        {
            return _context.Employees.FirstOrDefault(emp => emp.Id == id);
        }

        public string GetPay(int id)
        {
            var emp = GetById(id);
            decimal total;
            if(emp.Hours > 40)
            {
                total = (((emp.Hours - 40) + emp.RateOfPay / 2) + emp.Hours * emp.RateOfPay);
            }
            else
            {
                total = (emp.Hours * emp.RateOfPay);
            }
            string pay = total.ToString("C");
            return pay;
        }

        public string OverTime(int id)
        {
            var emp = GetById(id);
            if(emp.Hours > 40)
            {
                return $"Yes, {emp.Hours - 40} Hours";
            }
            else { return null; }
        }
    }
}
