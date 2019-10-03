using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PayrollCollections.Data;
using PayrollCollections.Models;

namespace PayrollCollections.Controllers
{
    public class EmployeesController : Controller
    {
        private readonly IEmployee _employeeService;

        public EmployeesController(IEmployee employeeService)
        {
            _employeeService = employeeService;
        }

        // GET: Employees
        public IActionResult Index()
        {
            var model = _employeeService.GetAll().Select(e => new EmployeeListingModel
            {
                Id = e.Id,
                Name = e.Name,
                Hours = e.Hours,
                PayWeek = e.PayWeek,
                TotalPay = _employeeService.GetPay(e.Id),
                OverTimePay = _employeeService.OverTime(e.Id)

            }) ;
            var empListingModel = model as IList<EmployeeListingModel> ?? model.ToList();

            var indexModel = new EmployeeViewModel
            {
                EmpList = empListingModel.OrderBy(e => e.Name),                
                NumberOfEmployees = empListingModel.Count()
            };
            return View(indexModel);
        }
        public IActionResult Details(int id)
        {
            var emp = _employeeService.GetById(id);
            var model = new EmployeeListingModel
            {
                Id = emp.Id,
                Name = emp.Name,
                Hours = emp.Hours,
                PayWeek = emp.PayWeek,
                RateOfPay = emp.RateOfPay
            };
            return View(model);
        }


        // GET: Employees/Create
        public IActionResult Create()
        {
            var Employee = new Employee();
            var model = new NewEmpModel
            {
                Id = Employee.Id,
                Name = Employee.Name,
                Hours = Employee.Hours,
                RateOfPay = Employee.RateOfPay,
                PayWeek = Employee.PayWeek
            };
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateValidation(NewEmpModel newEmp)
        {
                BuildEmp(newEmp);
                await _employeeService.Create(newEmp);
            return RedirectToAction("Index", "Employees");
        }

        public Employee BuildEmp(NewEmpModel newEmp)
        {
            return new Employee
            {
                Id = newEmp.Id,
                Name = newEmp.Name,
                Hours = newEmp.Hours,
                RateOfPay = newEmp.RateOfPay,
                PayWeek = newEmp.PayWeek
            };
        }

        public IActionResult Edit(int id)
        {
            var emp = _employeeService.GetById(id);
            var model = new NewEmpModel
            {
                Id = emp.Id,
                Name = emp.Name,
                Hours = emp.Hours,
                RateOfPay = emp.RateOfPay,
                PayWeek = emp.PayWeek
            };
            return View(model);
        }
        [HttpPost, ActionName("Edit")]
        [ValidateAntiForgeryToken]
        public IActionResult EditConfirmed(int id)
        {
            var employee = _employeeService.GetById(id);
            _employeeService.Edit(id);

            return RedirectToAction("Index", "Employees", new { id = employee.Id });

        }
        public IActionResult Delete(int id)
        {
            var emp = _employeeService.GetById(id);
            var model = new DeleteEmpModel
            {
                EmpId = emp.Id,
                Name = emp.Name
            };         
            return View(model);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            var employee = _employeeService.GetById(id);
            _employeeService.Delete(id);

            return RedirectToAction("Index", "Employees", new { id = employee.Id });

        }

    }
}
