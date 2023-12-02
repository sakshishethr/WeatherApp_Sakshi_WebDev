using Microsoft.AspNetCore.Mvc;

namespace WeatherApp_Sakshi_WebDev.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
