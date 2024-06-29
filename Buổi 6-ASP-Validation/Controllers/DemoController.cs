using Buổi_6_ASP_Validation.Models;
using Microsoft.AspNetCore.Mvc;

namespace Buổi_6_ASP_Validation.Controllers
{
    public class DemoController : Controller
    {
        public IActionResult Validation()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Validation(EmployeeInfo emp)
        {
            if(ModelState.IsValid)
            {
                ModelState.AddModelError("Message", "Hết lỗi rồi bạn !");
            }
            return View(emp);
        }


    }
}
