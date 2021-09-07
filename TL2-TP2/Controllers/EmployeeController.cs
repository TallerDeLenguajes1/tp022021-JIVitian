using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TL2_TP2.Models;

namespace TL2_TP2.Views.Home
{
    public class EmployeeController : Controller
    {
        private readonly ILogger<EmployeeController> _logger;

        public EmployeeController(ILogger<EmployeeController> logger)
        {
            _logger = logger;
            _logger.LogDebug(1, "NLog injected into HomeController");
        }

        // GET: EmployeeController
        public ActionResult Index()
        {
            Employee employee = new Employee(1, "Perez", "Juan", "4123131", DateTime.Now, "Mi casa jsjs", DateTime.Now, 40000);
            return View(employee);
        }

        [HttpPost]
        public ActionResult Show(IFormCollection data)
        {
            Employee employee = new Employee(0, data["LastName"], data["Name"], data["Dni"], DateTime.Parse(data["BirthDay"]), data["Address"], DateTime.Parse(data["EntryDate"]), float.Parse(data["BasicSalary"]));

            _logger.LogInformation($"Added a New Employee:\nLast name: {employee.LastName}\nName: {employee.Name}\nAge: {employee.Age}\nAntiquity: {employee.Antiquity}\nSalary: {employee.Salary}");

            return View(employee);
        }
    }
}
