using Microsoft.AspNetCore.Mvc;

namespace EFPractice.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
