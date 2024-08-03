using Microsoft.AspNetCore.Mvc;
using FirstApp.Bl;
using FirstApp.Models;

namespace FirstApp.Areas.admin.Controllers
{
    [Area("admin")]
    public class EmployeesController : Controller
    {
        public IActionResult List()
        {
            ClsEmployee oClsEmployee = new ClsEmployee();
            return View(oClsEmployee.GetData());
        }

        public IActionResult Edit()
        {
            return View(new EmployeeModel());
        }

        [AcceptVerbs("GET", "POST")]
        public IActionResult VerifyEmail(string email)
        {
            if (false)
            {
                return Json($"Email {email} is already in use.");
            }

            return Json(true);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Save(EmployeeModel employee)
        {
            if(!ModelState.IsValid)
                View("Edit", employee);


            // save employee in database

            return View("Edit", employee);
        }
    }
}
