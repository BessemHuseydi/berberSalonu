using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WEB.Models;

namespace WEB.Controllers
{
    public class CalisanController : Controller
    {
        private readonly BerberContext _context;

        public CalisanController(BerberContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }
        public IActionResult Index()
        {
            var calisanlar = _context.Calisanlar.Include(c => c.Salon).ToList(); // Salon ilişkisini dahil ediyoruz.
            return View(calisanlar);
        }
        // Çalışanları Listeleme (Belirli Bir Salon İçin veya Hepsi)
        public IActionResult Index2(int? salonId)
        {
            // Salonları ViewBag ile Dropdown için gönderiyoruz.
            ViewBag.Salonlar = _context.Salonlar.ToList();

            if (salonId == null)
            {
                // Eğer salon seçilmemişse, tüm çalışanları getiriyoruz.
                var calisanlar = _context.Calisanlar.Include(c => c.Salon).ToList();
                ViewBag.SelectedSalonName = "Tüm Salonlar";
                return View(calisanlar);
            }

            // Seçilen salonun bilgilerini getiriyoruz.
            var selectedSalon = _context.Salonlar.FirstOrDefault(s => s.Id == salonId);
            if (selectedSalon == null)
            {
                return NotFound("Seçilen salon bulunamadı.");
            }

            ViewBag.SelectedSalonName = selectedSalon.Name;

            // Seçilen salonun çalışanlarını getiriyoruz.
            var salonCalisanlari = _context.Calisanlar
                .Include(c => c.Salon)
                .Where(c => c.SalonId == salonId)
                .ToList();

            return View(salonCalisanlari);
        }


        // Çalışan Detayları (Read)
        public IActionResult Details(int id)
        {
            var calisan = _context.Calisanlar
                .Include(c => c.Salon)
                .FirstOrDefault(c => c.Id == id);

            if (calisan == null)
            {
                return NotFound("Çalışan bulunamadı.");
            }

            return View(calisan);
        }

        // Yeni Çalışan Ekleme (Create)
        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.Salonlar = _context.Salonlar.ToList(); // Salonları dropdown için gönderiyoruz.
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Calisan model)
        {
            if (ModelState.IsValid)
            {
                _context.Calisanlar.Add(model);
                _context.SaveChanges();

                TempData["SuccessMessage"] = "Çalışan başarılı bir şekilde kaydedildi!";
                return RedirectToAction("Index");
            }

            ViewBag.Salonlar = _context.Salonlar.ToList();
            return View(model);
        }

        // Çalışan Düzenleme (Update)
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var calisan = _context.Calisanlar.Find(id);
            if (calisan == null)
            {
                return NotFound("Çalışan bulunamadı.");
            }

            ViewBag.Salonlar = _context.Salonlar.ToList();
            return View(calisan);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Calisan model)
        {
            if (ModelState.IsValid)
            {
                var calisan = _context.Calisanlar.Find(model.Id);
                if (calisan == null)
                {
                    return NotFound("Çalışan bulunamadı.");
                }

                // Alanları güncelliyoruz.
                calisan.Name = model.Name;
                calisan.SalonId = model.SalonId;
               
                calisan.ExperienceYears = model.ExperienceYears;

                _context.Calisanlar.Update(calisan);
                _context.SaveChanges();

                TempData["SuccessMessage"] = "Çalışan bilgileri başarıyla güncellendi!";
                return RedirectToAction("Index");
            }

            ViewBag.Salonlar = _context.Salonlar.ToList();
            return View(model);
        }

        // Çalışan Silme (Delete)
        [HttpPost]
        public IActionResult Delete(int id)
        {
            var calisan = _context.Calisanlar.Find(id);
            if (calisan == null)
            {
                return NotFound("Çalışan bulunamadı.");
            }

            _context.Calisanlar.Remove(calisan);
            _context.SaveChanges();

            TempData["SuccessMessage"] = "Çalışan başarıyla silindi!";
            return RedirectToAction("Index");
        }


        // Salon Seçim Sayfası
        public IActionResult SalonSec()
        {
            // Salon listesini dropdown için ViewBag ile gönderiyoruz
            ViewBag.Salonlar = _context.Salonlar.ToList();
            return View();
        }

        // Seçilen Salonun Çalışanlarını Listeleme
        public IActionResult Listele(int salonId)
        {
            // Seçilen salonun çalışanlarını getiriyoruz
            var calisanlar = _context.Calisanlar
                .Include(c => c.Salon)
                .Where(c => c.SalonId == salonId)
                .ToList();

            // Eğer çalışan yoksa bir bilgi mesajı göster
            if (!calisanlar.Any())
            {
                TempData["InfoMessage"] = "Bu salona ait çalışan bulunmamaktadır.";
                return RedirectToAction("SalonSec");
            }

            ViewBag.SelectedSalonName = _context.Salonlar
                .FirstOrDefault(s => s.Id == salonId)?.Name;

            return View(calisanlar);
        }
    }
}

