using BootstrapEditableTable.Models;
using System.Collections.Generic;
using System.Web.Mvc;

namespace BootstrapEditableTable.Controllers
{
    public class EmployeeController : Controller
    {

        // GET: Employee
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetAll()
        {
            var employees = new List<Employee>()
            {
                new Employee {Id = 1, Name = "John Doe", Title ="Manager" },
                new Employee {Id = 2, Name = "Jenny Doe", Title ="Programmer" },
                new Employee {Id = 3, Name = "Jason Doe", Title ="Director" },
                new Employee {Id = 4, Name = "Jack Doe", Title ="Assistant" },
            };
            return Json(employees, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public ActionResult Update(List<Employee> employees)
        {

            return Json(new { Success = true, employees });
        }


    }
}