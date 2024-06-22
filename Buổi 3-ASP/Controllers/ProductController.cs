using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Buổi_3_ASP.Models;

namespace Buổi_3_ASP.Controllers
{
    public class ProductController : Controller
    {
        private static List<Product> products = new List<Product>
        {
            new Product { ID = 1, Name = "Ipad", Price = 12000000 },
            new Product { ID = 2, Name = "IPhone", Price = 24000000 },
            new Product { ID = 3, Name = "Laptop Dell", Price = 18000000 }
        };

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ShowAll()
        {
            ViewData["Heading"] = "All Product";
            return View(products);
        }

        public IActionResult AddProduct()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddProduct(Product product)
        {
            if (ModelState.IsValid)
            {
                product.ID = products.Count + 1; // Simple ID generation
                products.Add(product);
                return RedirectToAction("ShowAll");
            }
            return View(product);
        }

        public IActionResult EditProduct(int id)
        {
            var product = products.Find(p => p.ID == id);
            if (product == null)
            {
                return NotFound();
            }
            return View(product);
        }

        [HttpPost]
        public IActionResult EditProduct(Product product)
        {
            if (ModelState.IsValid)
            {
                var existingProduct = products.Find(p => p.ID == product.ID);
                if (existingProduct != null)
                {
                    existingProduct.Name = product.Name;
                    existingProduct.Price = product.Price;
                    return RedirectToAction("ShowAll");
                }
                return NotFound();
            }
            return View(product);
        }

        public IActionResult DeleteProduct(int id)
        {
            var product = products.Find(p => p.ID == id);
            if (product != null)
            {
                products.Remove(product);
                return RedirectToAction("ShowAll");
            }
            return NotFound();
        }
    }
}
