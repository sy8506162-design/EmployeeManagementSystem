using EmployeeSystem.Models;
using System.Collections.Generic;
using System.Web.Mvc;

namespace EmployeeSystem.Controllers
{
    public class EmployeeController : Controller
    {
        EmployeeDAL dal = new EmployeeDAL();

        public ActionResult Index()
        {
            List<Employee> employeeList = dal.GetAllEmployees();

            return View(employeeList);
        }
    }
}