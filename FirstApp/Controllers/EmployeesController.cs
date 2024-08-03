using Microsoft.AspNetCore.Mvc;
using FirstApp.Models;
using FirstApp.Bl;
namespace FirstApp.Controllers
{
    public class EmployeesController : Controller
    {
        List<EmployeeModel> lstEmployees;
        void CreateEmployeesList()
        {
            ClsEmployee oClsEmployee = new ClsEmployee();
            lstEmployees = oClsEmployee.GetData();
        }

        public IActionResult Create()
        {
            return View();
        }

        public IActionResult List()
        {
            ViewBag.Department = "Sales";
            ViewData["Salary"] = 5000;

            CreateEmployeesList();

            ViewBag.SalesMan = lstEmployees;
            return View(lstEmployees);
        }

        [AcceptVerbs("GET", "POST")]
        public IActionResult VerifyEmail(string Email)
        {
            if (false)
            {
                return Json($"Email {Email} is already in use.");
            }

            return Json(true);
        }

        public IActionResult Details(int id,string name)
        {
            decimal salary = Convert.ToDecimal( ViewData["Salary"]);
            string department = ViewBag.Department;
            CreateEmployeesList();
            var myEmployee = lstEmployees.Where(a => a.Id == id).FirstOrDefault();
            return View(myEmployee);
        }
    }
}
