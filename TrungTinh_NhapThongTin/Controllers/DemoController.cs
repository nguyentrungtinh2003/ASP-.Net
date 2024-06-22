using Microsoft.AspNetCore.Mvc;
using TrungTinh_NhapThongTin.Models;

namespace TrungTinh_NhapThongTin.Controllers
{
    public class DemoController : Controller
    {
        [HttpGet]
        public IActionResult NhapThongTin()
        {
            return View();
        }

        [HttpPost]
        public IActionResult KetQua(string name, int birthYear)
        {
            ViewBag.Name = name;
            ViewBag.BirthYear = birthYear;
            return View();
        }

        [HttpGet]
        public IActionResult Calculator()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Result(CalculatorModel model)
        {
            switch (model.Operation)
            {
                case "Cộng":
                    model.Result = model.Number1 + model.Number2;
                    break;
                case "Trừ":
                    model.Result = model.Number1 - model.Number2;
                    break;
                case "Nhân":
                    model.Result = model.Number1 * model.Number2;
                    break;
                case "Chia":
                    model.Result = model.Number1 / model.Number2;
                    break;
            }

            return View(model);
        }
    }
}
