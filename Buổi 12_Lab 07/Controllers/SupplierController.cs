using Buổi_12_Lab_07.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Buổi_12_Lab_07.Controllers
{
    public class SupplierController : Controller
    {
        private readonly Dblab07Context _context;

        public SupplierController(Dblab07Context context)
        {
            _context = context;
        }

        // GET: Supplier/Index
        public IActionResult Index()
        {
            var data = _context.Suppliers.ToList();
            return View(data);
        }

        // POST: Supplier/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Supplier supplier)
        {
            if (ModelState.IsValid)
            {
                _context.Suppliers.Add(supplier);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(supplier);
        }


        // GET: Supplier/Edit/5
        public IActionResult Edit(string id)
        {
            var supplier = _context.Suppliers.Find(id);
            if (supplier == null)
            {
                return NotFound();
            }
            return View(supplier);
        }

        // POST: Supplier/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(string id, Supplier supplier)
        {
            if (id != supplier.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(supplier);
                    _context.SaveChanges();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SupplierExists(supplier.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(supplier);
        }

        private bool SupplierExists(string id)
        {
            return _context.Suppliers.Any(e => e.Id == id);
        }

        // GET: Supplier/Delete/5
        public IActionResult Delete(string id)
        {
            var supplier = _context.Suppliers.Find(id);
            if (supplier == null)
            {
                return NotFound();
            }
            return View(supplier);
        }

        // POST: Supplier/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(string id)
        {
            var supplier = _context.Suppliers.Find(id);
            if (supplier != null)
            {
                _context.Suppliers.Remove(supplier);
                _context.SaveChanges();
            }
            return RedirectToAction(nameof(Index));
        }
    }
}
