using Microsoft.AspNetCore.Mvc;

namespace Buổi_10_Layout_Fruitables.Controllers
{
    public class ProductsController : Controller
    {
        public IActionResult Shop()
        {
            return View();
        }

        public IActionResult ShopDetail()
        {
            return View();
        }
        public IActionResult Test()
        {
            return View();
        }
    }
}
