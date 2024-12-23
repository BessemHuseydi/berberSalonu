using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

using WEB.Models;

namespace WEB.Controllers
{
    public class RandevuController : Controller
    {
        private readonly BerberContext _context;

        public RandevuController(BerberContext context)
        {
            _context = context;
        }

        // GET: Randevu
        public async Task<IActionResult> Index()
        {
            var randevular = _context.Randevular
                .Include(r => r.User)
                .Include(r => r.Salon);
                
            return View(await randevular.ToListAsync());
        }

        // GET: Randevu/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var randevu = await _context.Randevular
                .Include(r => r.User)
                .Include(r => r.Salon)
                
                .FirstOrDefaultAsync(m => m.Id == id);
            if (randevu == null)
            {
                return NotFound();
            }

            return View(randevu);
        }

        // GET: Randevu/Create
        public IActionResult Create()
        {
            PopulateDropdowns();
            return View();
        }

        // POST: Randevu/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create2([Bind("Id,UserId,SalonId,HizmetId,AppointmentTime,Price")] Randevu randevu)
        {
            if (ModelState.IsValid)
            {
                // Randevu zamanının kontrolü
                bool isTimeSlotTaken = await _context.Randevular.AnyAsync(r =>
                    r.SalonId == randevu.SalonId &&
                    r.AppointmentTime == randevu.AppointmentTime);

                if (isTimeSlotTaken)
                {
                    ModelState.AddModelError("", "Seçilen salon ve zaman için zaten bir randevu mevcut.");
                    PopulateDropdowns(randevu);
                    return View(randevu);
                }

                _context.Add(randevu);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            PopulateDropdowns(randevu);
            return RedirectToAction("Datails");
        }

        // GET: Randevu/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var randevu = await _context.Randevular.FindAsync(id);
            if (randevu == null)
            {
                return NotFound();
            }
            PopulateDropdowns(randevu);
            return View(randevu);
        }

        // POST: Randevu/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,UserId,SalonId,HizmetId,AppointmentTime,Price")] Randevu randevu)
        {
            if (id != randevu.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    // Randevu zamanının kontrolü
                    bool isTimeSlotTaken = await _context.Randevular.AnyAsync(r =>
                        r.SalonId == randevu.SalonId &&
                        r.AppointmentTime == randevu.AppointmentTime &&
                        r.Id != randevu.Id);

                    if (isTimeSlotTaken)
                    {
                        ModelState.AddModelError("", "Seçilen salon ve zaman için zaten bir randevu mevcut.");
                        PopulateDropdowns(randevu);
                        return View(randevu);
                    }

                    _context.Update(randevu);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RandevuExists(randevu.Id))
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
            PopulateDropdowns(randevu);
            return View(randevu);
        }

        // GET: Randevu/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var randevu = await _context.Randevular
                .Include(r => r.User)
                .Include(r => r.Salon)
                
                .FirstOrDefaultAsync(m => m.Id == id);
            if (randevu == null)
            {
                return NotFound();
            }

            return View(randevu);
        }

        // POST: Randevu/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var randevu = await _context.Randevular.FindAsync(id);
            _context.Randevular.Remove(randevu);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RandevuExists(int id)
        {
            return _context.Randevular.Any(e => e.Id == id);
        }

        private void PopulateDropdowns(Randevu randevu = null)
        {
            var users = _context.Users.Select(u => new { u.Id, u.Name }).ToList();
            var salonlar = _context.Salonlar.Select(s => new { s.Id, s.Name }).ToList();
            var hizmetler = _context.Hizmetler.Select(h => new { h.Id, h.Name }).ToList();

            ViewBag.UserId = new SelectList(users, "Id", "Name", randevu?.UserId);
            ViewBag.SalonId = new SelectList(salonlar, "Id", "Name", randevu?.SalonId);
            
        }
    }
}
