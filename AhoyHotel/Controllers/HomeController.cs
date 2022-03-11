using Microsoft.AspNetCore.Mvc;

namespace AhoyHotelApi.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
