using Buổi_6_ASP_Validation.Models;
using Microsoft.AspNetCore.Mvc;

namespace Buổi_6_ASP_Validation.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        /*[HttpGet]
        public IActionResult Employee()
        {
            if(ModelState.IsValid)
            {
                //save employee

            }
            return View();
        }*/

        /*[HttpPost]*/
        public IActionResult Employee(Employee model)
        {
            return View(model);
        }
    }
}
