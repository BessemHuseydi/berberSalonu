using Bshop.Data;
using Bshop.Models;
using Bshop.ViewModelleri;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace Bshop.Controllers
{
    [Authorize(Roles = "Admin")]
    public class AdminController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AdminController(ApplicationDbContext context)
        {
            _context = context;
        }

        // **1. Kullanıcı Yönetimi**
        // GET: Admin/Index
        public IActionResult Index()
        {
            return View();
        }

        // Kullanıcıları Listeleme
        public async Task<IActionResult> Users()
        {
            var users = await _context.Users.ToListAsync();
            return View(users);
        }

        // GET: Admin/EditUser/5
        public async Task<IActionResult> EditUser(int id)
        {
            var user = await _context.Users.FindAsync(id);
            if (user == null)
            {
                TempData["msj"] = "Kullanıcı bulunamadı.";
                return RedirectToAction("Users");
            }

            var viewModel = new EditUserViewModel
            {
                Id = user.Id,
                FullName = user.FullName,
                Phone = user.Phone,
                Email = user.Email,
                Password = user.Password,
                Role = user.Role,
                Roles = Enum.GetValues(typeof(UserRole)).Cast<UserRole>().Select(r => new SelectListItem
                {
                    Value = r.ToString(),
                    Text = r.ToString()
                })
            };

            return View(viewModel);
        }

        // POST: Admin/EditUser/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditUser(int id, EditUserViewModel model)
        {
            if (id != model.Id)
            {
                TempData["msj"] = "Geçersiz kullanıcı ID.";
                return RedirectToAction("Users");
            }

            if (ModelState.IsValid)
            {
                try
                {
                    var existingUser = await _context.Users.FindAsync(id);
                    if (existingUser == null)
                    {
                        TempData["msj"] = "Kullanıcı bulunamadı.";
                        return RedirectToAction("Users");
                    }

                    existingUser.FullName = model.FullName;
                    existingUser.Phone = model.Phone;
                    existingUser.Email = model.Email;
                    existingUser.Password = model.Password;
                    existingUser.Role = model.Role;

                    _context.Update(existingUser);
                    await _context.SaveChangesAsync();

                    TempData["msj"] = $"{existingUser.FullName} adlı kullanıcı başarıyla güncellendi.";
                    return RedirectToAction("Users");
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UserExists(model.Id))
                    {
                        TempData["msj"] = "Kullanıcı bulunamadı.";
                        return RedirectToAction("Users");
                    }
                    else
                    {
                        TempData["msj"] = "Güncelleme sırasında bir hata oluştu.";
                        throw;
                    }
                }
            }

            // Gerekli verileri tekrar yükleyin
            model.Roles = Enum.GetValues(typeof(UserRole)).Cast<UserRole>().Select(r => new SelectListItem
            {
                Value = r.ToString(),
                Text = r.ToString()
            });
            TempData["msj"] = "Lütfen formu doğru doldurun.";
            return View(model);
        }

        // Kullanıcı Silme
        public async Task<IActionResult> DeleteUser(int id)
        {
            var user = await _context.Users.FindAsync(id);
            if (user == null)
            {
                TempData["msj"] = "Kullanıcı bulunamadı.";
                return RedirectToAction("Users");
            }

            return View(user);
        }

        [HttpPost, ActionName("DeleteUser")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteUserConfirmed(int id)
        {
            var user = await _context.Users.FindAsync(id);
            if (user != null)
            {
                _context.Users.Remove(user);
                await _context.SaveChangesAsync();
                TempData["msj"] = $"{user.FullName} adlı kullanıcı silindi.";
            }
            else
            {
                TempData["msj"] = "Kullanıcı bulunamadı.";
            }
            return RedirectToAction(nameof(Users));
        }

        private bool UserExists(int id)
        {
            return _context.Users.Any(u => u.Id == id);
        }

        // **2. Salon Yönetimi**

        // Salonları Listeleme
        public async Task<IActionResult> Salons()
        {
            var salons = await _context.Salons.ToListAsync();
            return View(salons);
        }

        // Salon Ekleme
        public IActionResult CreateSalon()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CreateSalon(Salon salon)
        {
            if (ModelState.IsValid)
            {
                _context.Add(salon);
                _context.SaveChangesAsync();
                TempData["msj"] = $"{salon.Name} adlı salon eklendi.";
                return RedirectToAction("Salons");
            }
            TempData["msj"] = "Lütfen formu doğru doldurun.";
            return View(salon);
        }

        // Salon Düzenleme
        public IActionResult EditSalon(int id)
        {
            var salon = _context.Salons.FindAsync(id);
            if (salon == null)
            {
                TempData["msj"] = "Salon bulunamadı.";
                return RedirectToAction("Index");
            }
            return View(salon);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult EditSalon(int id,  Salon salon)
        {
            if (id != salon.Id)
            {
                TempData["msj"] = "Geçersiz salon ID.";
                return RedirectToAction("Salons");
            }

            if (ModelState.IsValid)
            {
                
                    _context.Update(salon);
                    _context.SaveChangesAsync();
                    TempData["msj"] = $"{salon.Name} adlı salon başarıyla güncellendi.";
               
                return RedirectToAction("Index");
            }
            TempData["msj"] = "Lütfen formu doğru doldurun.";
            return View(salon);
        }

        // Salon Silme
        public async Task<IActionResult> DeleteSalon(int id)
        {
            var salon = await _context.Salons.FindAsync(id);
            if (salon == null)
            {
                TempData["msj"] = "Salon bulunamadı.";
                return RedirectToAction(nameof(Salons));
            }

            return View(salon);
        }

        [HttpPost, ActionName("DeleteSalon")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteSalonConfirmed(int id)
        {
            var salon = await _context.Salons.FindAsync(id);
            if (salon != null)
            {
                _context.Salons.Remove(salon);
                await _context.SaveChangesAsync();
                TempData["msj"] = $"{salon.Name} adlı salon silindi.";
            }
            else
            {
                TempData["msj"] = "Salon bulunamadı.";
            }
            return RedirectToAction(nameof(Salons));
        }

        private bool SalonExists(int id)
        {
            return _context.Salons.Any(s => s.Id == id);
        }

        // **3. Hizmet Yönetimi**

        // Hizmetleri Listeleme
        public async Task<IActionResult> Hizmets()
        {
            var hizmetler = await _context.Hizmets.ToListAsync();
            return View(hizmetler);
        }

        // Hizmet Ekleme
        public IActionResult CreateHizmet()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CreateHizmet( Hizmet hizmet)
        {
            if (ModelState.IsValid)
            {
                // PhotoUrl alanını sabit bir değerle set ediyoruz
                //hizmet.PhotoUrl = "~/img/hizmetler/sakalbakimi.jpg";

                _context.Add(hizmet);
                 _context.SaveChangesAsync();
                TempData["msj"] = $"{hizmet.Name} adlı hizmet eklendi.";
                return RedirectToAction("Hizmets");
            }
            TempData["msj"] = "Lütfen formu doğru doldurun.";
            return View(hizmet);
        }

        // Hizmet Düzenleme
        public async Task<IActionResult> EditHizmet(int id)
        {
            var hizmet = await _context.Hizmets.FindAsync(id);
            if (hizmet == null)
            {
                TempData["msj"] = "Hizmet bulunamadı.";
                return RedirectToAction(nameof(Hizmets));
            }
            return View(hizmet);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditHizmet(int id, [Bind("Id,Name,Description,DurationMinutes,Price,PhotoUrl")] Hizmet hizmet)
        {
            if (id != hizmet.Id)
            {
                TempData["msj"] = "Geçersiz hizmet ID.";
                return RedirectToAction(nameof(Hizmets));
            }

            if (ModelState.IsValid)
            {
                try
                {
                    // PhotoUrl'ü sabit tutmak istiyorsanız aşağıdaki satırı kullanabilirsiniz.
                    //hizmet.PhotoUrl = "~/img/hizmetler/sakalbakimi.jpg";

                    _context.Update(hizmet);
                    await _context.SaveChangesAsync();
                    TempData["msj"] = $"{hizmet.Name} adlı hizmet başarıyla güncellendi.";
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!HizmetExists(hizmet.Id))
                    {
                        TempData["msj"] = "Hizmet bulunamadı.";
                        return RedirectToAction(nameof(Hizmets));
                    }
                    else
                    {
                        TempData["msj"] = "Güncelleme sırasında bir hata oluştu.";
                        throw;
                    }
                }
                return RedirectToAction(nameof(Hizmets));
            }
            TempData["msj"] = "Lütfen formu doğru doldurun.";
            return View(hizmet);
        }

        // Hizmet Silme
        public async Task<IActionResult> DeleteHizmet(int id)
        {
            var hizmet = await _context.Hizmets.FindAsync(id);
            if (hizmet == null)
            {
                TempData["msj"] = "Hizmet bulunamadı.";
                return RedirectToAction(nameof(Hizmets));
            }

            return View(hizmet);
        }

        [HttpPost, ActionName("DeleteHizmet")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteHizmetConfirmed(int id)
        {
            var hizmet = await _context.Hizmets.FindAsync(id);
            if (hizmet != null)
            {
                _context.Hizmets.Remove(hizmet);
                await _context.SaveChangesAsync();
                TempData["msj"] = $"{hizmet.Name} adlı hizmet silindi.";
            }
            else
            {
                TempData["msj"] = "Hizmet bulunamadı.";
            }
            return RedirectToAction(nameof(Hizmets));
        }

        private bool HizmetExists(int id)
        {
            return _context.Hizmets.Any(h => h.Id == id);
        }
    }
}
