using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Bshop.Data;
using Bshop.Models;
using Microsoft.EntityFrameworkCore;

namespace Bshop.Controllers
{
    public class HizmetController : Controller
    {
        private readonly ApplicationDbContext _context;

        // DbContext'i constructor üzerinden alıyoruz
        public HizmetController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Hizmet/Index
        public IActionResult Index()
        {
            var hizmetler = _context.Hizmets.ToList();
            return View(hizmetler);
        }

        // GET: Hizmet/Details/5
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hizmet = _context.Hizmets.FirstOrDefault(m => m.Id == id);
            if (hizmet == null)
            {
                return NotFound();
            }

            return View(hizmet);
        }

        // GET: Hizmet/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Hizmet/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Hizmet hiz)
        {
            if (ModelState.IsValid)
            {
                // PhotoUrl alanını sabit bir değerle set ediyoruz
                hiz.PhotoUrl = "~/img/hizmetler/sakalbakimi.jpg";

                _context.Hizmets.Add(hiz);
                _context.SaveChanges();
                TempData["msj"] = $"{hiz.Name} adlı hizmet eklendi.";
                return RedirectToAction("Index");
            }

            TempData["msj"] = "Lütfen verileri düzgün giriniz.";
            return RedirectToAction("Create");
        }

        // GET: Hizmet/Edit/5
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hizmet = _context.Hizmets.Find(id);
            if (hizmet == null)
            {
                return NotFound();
            }
            return View(hizmet);
        }

        // POST: Hizmet/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, Hizmet hiz)
        {
            if (id != hiz.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    // PhotoUrl'ü sabit tutmak veya güncellemek istiyorsanız burada set edebilirsiniz
                    hiz.PhotoUrl = "~/img/hizmetler/sakalbakimi.jpg";

                    _context.Hizmets.Update(hiz);
                    _context.SaveChanges();
                    TempData["msj"] = $"{hiz.Name} adlı hizmet güncellendi.";
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!HizmetExists(hiz.Id))
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
            return RedirectToAction("Edit", new { id = hiz.Id });
        }

        // GET: Hizmet/Delete/5
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hizmet = _context.Hizmets.FirstOrDefault(m => m.Id == id);
            if (hizmet == null)
            {
                return NotFound();
            }

            return View(hizmet);
        }

        // POST: Hizmet/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            var hizmet = _context.Hizmets.Find(id);
            if (hizmet != null)
            {
                _context.Hizmets.Remove(hizmet);
                _context.SaveChanges();
                TempData["msj"] = $"{hizmet.Name} adlı hizmet silindi.";
            }
            return RedirectToAction("Index");
        }

        private bool HizmetExists(int id)
        {
            return _context.Hizmets.Any(e => e.Id == id);
        }
    }
}
