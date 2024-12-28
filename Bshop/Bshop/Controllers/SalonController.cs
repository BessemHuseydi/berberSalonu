using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Bshop.Data;
using Bshop.Models;
using Microsoft.EntityFrameworkCore;

namespace Bshop.Controllers
{
    public class SalonController : Controller
    {
        private readonly ApplicationDbContext _context;

        // DbContext'i constructor üzerinden alıyoruz
        public SalonController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Salon/Index
        public IActionResult Index()
        {
            var salons = _context.Salons.ToList();
            return View(salons);
        }

        // GET: Salon/Details/5
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var salon = _context.Salons.FirstOrDefault(m => m.Id == id);
            if (salon == null)
            {
                return NotFound();
            }

            return View(salon);
        }

        // GET: Salon/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Salon/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Salon salon)
        {
            if (ModelState.IsValid)
            {
                _context.Salons.Add(salon);
                _context.SaveChanges();
                TempData["msj"] = $"{salon.Name} adlı salon eklendi.";
                return RedirectToAction("Index");
            }

            TempData["msj"] = "Lütfen verileri düzgün giriniz.";
            return RedirectToAction("Create");
        }

        // GET: Salon/Edit/5
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var salon = _context.Salons.Find(id);
            if (salon == null)
            {
                return NotFound();
            }
            return View(salon);
        }

        // POST: Salon/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, Salon salon)
        {
            if (id != salon.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Salons.Update(salon);
                    _context.SaveChanges();
                    TempData["msj"] = $"{salon.Name} adlı salon güncellendi.";
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SalonExists(salon.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction("Index");
            }

            TempData["msj"] = "Lütfen verileri düzgün giriniz.";
            return RedirectToAction("Edit", new { id = salon.Id });
        }

        // GET: Salon/Delete/5
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var salon = _context.Salons.FirstOrDefault(m => m.Id == id);
            if (salon == null)
            {
                return NotFound();
            }

            return View(salon);
        }

        // POST: Salon/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            var salon = _context.Salons.Find(id);
            if (salon != null)
            {
                _context.Salons.Remove(salon);
                _context.SaveChanges();
                TempData["msj"] = $"{salon.Name} adlı salon silindi.";
            }
            return RedirectToAction("Index");
        }

        private bool SalonExists(int id)
        {
            return _context.Salons.Any(e => e.Id == id);
        }
    }
}
