using Microsoft.AspNetCore.Mvc;

namespace CleanArch.MVCCore.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
