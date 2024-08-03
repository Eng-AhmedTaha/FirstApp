using Microsoft.AspNetCore.Mvc;

namespace FirstApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Default()
        {
            return RedirectToAction("Login");
        }

        public int Login()
        {
            return 10;
        }


    }
}
