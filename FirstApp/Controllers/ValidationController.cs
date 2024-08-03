using Microsoft.AspNetCore.Mvc;

namespace FirstApp.Controllers
{
    public class ValidationController : Controller
    {
        public IActionResult Index()
        {
            return View();
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
    }
}
