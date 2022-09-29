using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            Employee employee = new Employee()
            {
                EmployeeID = 101,
                Name = "Pratham Aggarwal",
                Gender = "Male",
                Branch = "Devops",
                Section = "A"
            };
            Address add = new Address()
            {
                EmployeeID = 101,
                City = "Rewari",
                State = "Haryana",
                Country = "India",
                Pincode = "100562"
            };

            EmployeeDetailsViewModel employeeDetailsViewModel = new EmployeeDetailsViewModel()
            {
                employee = employee,
                address = add,
                Header = "Employee Data",
                Title = "Employee Details"



            };
            return View(employeeDetailsViewModel);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
