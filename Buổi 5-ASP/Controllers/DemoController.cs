using Microsoft.AspNetCore.Mvc;

namespace Buổi_5_ASP.Controllers
{
    public class DemoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
