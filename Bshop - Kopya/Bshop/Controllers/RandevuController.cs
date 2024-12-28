using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Bshop.Data;
using Bshop.Models;
using Bshop.ViewModelleri;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Hosting;
using System;


namespace Bshop.Controllers
{
    public class RandevuController : Controller
    {
        private readonly ApplicationDbContext _context;

        public RandevuController(ApplicationDbContext context)
        {
            _context = context;
        }

        //public async Task<IActionResult> Index()
        //{
        //    var randevular = await _context.Randevular
        //        .Include(r => r.Salon) // Salon bilgisi
        //        .Include(r => r.CalisanHizmet)
        //            .ThenInclude(ch => ch.Calisan) // Çalışan bilgisi
        //        .Include(r => r.CalisanHizmet)
        //            .ThenInclude(ch => ch.Hizmet) // Hizmet bilgisi
        //        .ToListAsync();

        //    return View(randevular);
        //}

        public async Task<IActionResult> Index()
        {
            // Giriş yapan kullanıcıyı al
            var currentUserName = User.Identity.Name;
            var currentUser = await _context.Users.FirstOrDefaultAsync(u => u.FullName == currentUserName);

            if (currentUser == null)
            {
                return RedirectToAction("Login", "Account"); // Kullanıcı giriş yapmadıysa yönlendirme
            }

            // Kullanıcının randevularını al
            var randevular = await _context.Randevular
                .Include(r => r.Salon)
                .Include(r => r.CalisanHizmet)
                    .ThenInclude(ch => ch.Calisan)
                .Include(r => r.CalisanHizmet)
                    .ThenInclude(ch => ch.Hizmet)
                .Where(r => r.UserId == currentUser.Id) // Sadece giriş yapan kullanıcının randevuları
                .ToListAsync();

            // Geçmiş ve gelecekteki randevuları ayır
            ViewBag.GecmisRandevular = randevular.Where(r => r.RandevuSaati < DateTime.Now).ToList();
            ViewBag.GelecekRandevular = randevular.Where(r => r.RandevuSaati >= DateTime.Now).ToList();

            return View();
        }

        [HttpGet]
        public ActionResult Create()
        {
            // Dropdown için veri kaynaklarını doldurma
            ViewBag.Salons = _context.Salons.Select(s => new SelectListItem
            {
                Value = s.Id.ToString(),
                Text = s.Name
            }).ToList();

            ViewBag.CalisanHizmetler = _context.CalisanHizmets.Select(ch => new SelectListItem
            {
                Value = ch.Id.ToString(),
                Text = ch.Calisan.FullName + ch.Hizmet.Name
            }).ToList();

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Randevu randevu)
        {
            // Kullanıcı bilgilerini al
            var currentUserName = User.Identity.Name; // Kullanıcı oturumunda kimliği alır
            var currentUser = _context.Users.FirstOrDefault(u => u.FullName == currentUserName);

            if (currentUser == null)
            {
                ModelState.AddModelError("", "Geçersiz kullanıcı oturumu.");
                return View(randevu);
            }

            randevu.UserId = currentUser.Id; // Kullanıcının ID'sini doğrudan atar

            if (ModelState.IsValid)
            {
                _context.Randevular.Add(randevu);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }

            // Model geçersizse, dropdownları tekrar doldur
            ViewBag.Salons = _context.Salons.Select(s => new SelectListItem
            {
                Value = s.Id.ToString(),
                Text = s.Name
            }).ToList();

            ViewBag.CalisanHizmetler = _context.CalisanHizmets.Select(ch => new SelectListItem
            {
                Value = ch.Id.ToString(),
                Text = ch.Calisan.FullName + ch.Hizmet.Name
            }).ToList();

            return View(randevu);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var randevu = await _context.Randevular
                .Include(r => r.Salon)
                .Include(r => r.CalisanHizmet)
                .FirstOrDefaultAsync(r => r.Id == id);

            if (randevu == null)
            {
                return NotFound();
            }

            // Dropdown verilerini doldur
            ViewBag.Salons = _context.Salons.Select(s => new SelectListItem
            {
                Value = s.Id.ToString(),
                Text = s.Name
            }).ToList();

            ViewBag.CalisanHizmetler = _context.CalisanHizmets.Select(ch => new SelectListItem
            {
                Value = ch.Id.ToString(),
                Text = ch.Calisan.FullName + ch.Hizmet.Name
            }).ToList();

            return View(randevu);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Randevu randevu)
        {
            if (!ModelState.IsValid)
            {
                // Dropdown verilerini tekrar doldur
                ViewBag.Salons = _context.Salons.Select(s => new SelectListItem
                {
                    Value = s.Id.ToString(),
                    Text = s.Name
                }).ToList();

                ViewBag.CalisanHizmetler = _context.CalisanHizmets.Select(ch => new SelectListItem
                {
                    Value = ch.Id.ToString(),
                    Text = ch.Calisan.FullName + ch.Hizmet.Name
                }).ToList();

                return View(randevu);
            }

            var existingRandevu = await _context.Randevular.FindAsync(randevu.Id);
            if (existingRandevu == null)
            {
                return NotFound();
            }

            // Güncelleme işlemi
            existingRandevu.SalonId = randevu.SalonId;
            existingRandevu.CalisanHizmetId = randevu.CalisanHizmetId;
            existingRandevu.RandevuSaati = randevu.RandevuSaati;
            existingRandevu.Onaylandi = randevu.Onaylandi;

            _context.Randevular.Update(existingRandevu);
            await _context.SaveChangesAsync();

            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> EditWorker(int id)
        {
            // Randevuyu al
            var randevu = await _context.Randevular
                .Include(r => r.Salon)
                .Include(r => r.CalisanHizmet)
                    .ThenInclude(ch => ch.Calisan)
                .Include(r => r.CalisanHizmet)
                    .ThenInclude(ch => ch.Hizmet)
                .FirstOrDefaultAsync(r => r.Id == id);

            if (randevu == null)
            {
                return NotFound(); // Eğer randevu yoksa hata döndür
            }

            // Dropdownları doldur
            ViewBag.Salons = _context.Salons.Select(s => new SelectListItem
            {
                Value = s.Id.ToString(),
                Text = s.Name
            }).ToList();

            ViewBag.CalisanHizmetler = _context.CalisanHizmets.Select(ch => new SelectListItem
            {
                Value = ch.Id.ToString(),
                Text = ch.Calisan.FullName + " - " + ch.Hizmet.Name
            }).ToList();

            return View(randevu); // Düzenleme sayfasını göster
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditWorker(Randevu randevu)
        {
            if (!ModelState.IsValid)
            {
                // Dropdownları tekrar doldur
                ViewBag.Salons = _context.Salons.Select(s => new SelectListItem
                {
                    Value = s.Id.ToString(),
                    Text = s.Name
                }).ToList();

                ViewBag.CalisanHizmetler = _context.CalisanHizmets.Select(ch => new SelectListItem
                {
                    Value = ch.Id.ToString(),
                    Text = ch.Calisan.FullName + " - " + ch.Hizmet.Name
                }).ToList();

                return View(randevu); // Hatalarla birlikte formu geri döndür
            }

            var existingRandevu = await _context.Randevular.FirstOrDefaultAsync(r => r.Id == randevu.Id);

            if (existingRandevu == null)
            {
                return NotFound(); // Eğer randevu yoksa hata döndür
            }

            // Randevuyu güncelle
            existingRandevu.SalonId = randevu.SalonId;
            existingRandevu.CalisanHizmetId = randevu.CalisanHizmetId;
            existingRandevu.RandevuSaati = randevu.RandevuSaati;
            existingRandevu.Onaylandi = randevu.Onaylandi;

            _context.Randevular.Update(existingRandevu);
            await _context.SaveChangesAsync();

            return RedirectToAction("AllRandevular"); // Başarılı işlem sonrası yönlendirme
        }
       

        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            // Silinecek randevuyu alın
            var randevu = await _context.Randevular
                .Include(r => r.Salon)
                .Include(r => r.CalisanHizmet)
                    .ThenInclude(ch => ch.Hizmet)
                .FirstOrDefaultAsync(r => r.Id == id);

            if (randevu == null)
            {
                return NotFound(); // Randevu bulunamadıysa 404 döndür
            }

            return View(randevu); // Silme onay sayfasını göster
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            // Silinecek randevuyu alın
            var randevu = await _context.Randevular.FindAsync(id);

            if (randevu == null)
            {
                return NotFound(); // Randevu bulunamadıysa 404 döndür
            }

            // Randevuyu veritabanından sil
            _context.Randevular.Remove(randevu);
            await _context.SaveChangesAsync();

            return RedirectToAction("Index"); // Başarılıysa Index sayfasına yönlendirme
        }
        [HttpGet]
        public async Task<IActionResult> AllRandevular()
        {
            // Tüm randevuları, ilişkili tablolarla birlikte alıyoruz
            var randevular = await _context.Randevular
                .Include(r => r.Salon)
                .Include(r => r.CalisanHizmet)
                    .ThenInclude(ch => ch.Calisan)
                .Include(r => r.CalisanHizmet)
                    .ThenInclude(ch => ch.Hizmet)
                .Include(r => r.User) // Randevuyu alan kullanıcıyı dahil ediyoruz
                .ToListAsync();

            // Onaylanmış ve onaylanmamış randevuları ayır
            ViewBag.OnaylanmisRandevular = randevular.Where(r => r.Onaylandi).ToList();
            ViewBag.OnaylanmamisRandevular = randevular.Where(r => !r.Onaylandi).ToList();

            return View();
        }




    }
}
