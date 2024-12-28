using Bshop.Data;
using Bshop.Models;
using Bshop.ViewModelleri;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace Bshop.Controllers
{
    public class CalisanController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CalisanController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Calisan/Index
        public async Task<IActionResult> Index()
        {
            var calisanlar = await _context.Calisans
                .Include(c => c.Salon) // Salon ilişkisini dahil ediyoruz.
                .ToListAsync();
            return View(calisanlar);
        }

        // GET: Calisan/Index2
        public async Task<IActionResult> Index2(int? salonId)
        {
            // Salonları ViewBag ile Dropdown için gönderiyoruz.
            ViewBag.Salonlar = await _context.Salons.OrderBy(s => s.Name).ToListAsync();

            if (salonId == null)
            {
                // Eğer salon seçilmemişse, tüm çalışanları getiriyoruz.
                var calisanlar = await _context.Calisans
                    .Include(c => c.Salon)
                    .ToListAsync();
                ViewBag.SelectedSalonName = "Tüm Salonlar";
                return View(calisanlar);
            }

            // Seçilen salonun bilgilerini getiriyoruz.
            var selectedSalon = await _context.Salons.FirstOrDefaultAsync(s => s.Id == salonId);
            if (selectedSalon == null)
            {
                return NotFound("Seçilen salon bulunamadı.");
            }

            ViewBag.SelectedSalonName = selectedSalon.Name;

            // Seçilen salonun çalışanlarını getiriyoruz.
            var salonCalisanlari = await _context.Calisans
                .Include(c => c.Salon)
                .Where(c => c.SalonId == salonId)
                .ToListAsync();

            return View(salonCalisanlari);
        }


    }
}