using Microsoft.AspNetCore.Mvc;
using WEB.Models;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace WEB.Controllers
{
    public class AccountController : Controller
    {
        private readonly BerberContext _context;

        public AccountController(BerberContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        // GET: SignUp
        public IActionResult SignUp()
        {
            return View();
        }

        // POST: SignUp
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult SignUp22(User model)
        {
            if (ModelState.IsValid)
            {
                // Kullanıcı zaten mevcut mu kontrol et
                if (_context.Users.Any(u => u.Email == model.Email))
                {
                    ModelState.AddModelError("Email", "Bu e-posta adresiyle kayıtlı bir kullanıcı zaten var.");
                    return View(model); // Aynı view'e geri dön
                }

                // Şifreyi hashle
                model.PasswordHash = model.PasswordHash;

                // Kullanıcıyı veritabanına ekle
                _context.Users.Add(model);
                _context.SaveChanges();

                // Başarılı kayıt mesajı
                TempData["msj"] = "Kayıt başarılı! Giriş yapabilirsiniz.";
                return RedirectToAction("Login"); // Login sayfasına yönlendir
            }


            // Model doğrulama başarısızsa aynı formu geri döndür
            TempData["msj"] = "Kayıt başarılısız! ";
            return View(model);
        }

        // Login - GET
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        // Login - POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        
        public IActionResult UsrLogin22(User u)
        {
            // Kullanıcıyı veritabanında email ile ara
            var user = _context.Users.FirstOrDefault(x => x.Email == u.Email);

            if (user == null)
            {
                TempData["msj"] = "Kullanıcı bulunamadı.";
                return RedirectToAction("Login");
            }

            // Şifre doğrulaması
            if (user.PasswordHash != u.PasswordHash)
            {
                TempData["msj"] = "Şifre hatalı.";
                return RedirectToAction("Login");
            }

            // Kullanıcı giriş başarılı
            TempData["UserName"] = user.Name;
            return View("Welcome");
        }
        // POST: Users/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Name,Phone,Email,PasswordHash")] User user)
        {
            if (ModelState.IsValid)
            {
                // Şifreyi hashleyin
                user.PasswordHash = user.PasswordHash;

                // Kullanıcıyı veritabanına ekleyin
                _context.Add(user);
                await _context.SaveChangesAsync();

                // Başarılı kayıt mesajı
                TempData["msj"] = "Kayıt başarılı! Giriş yapabilirsiniz.";
                return RedirectToAction("Login"); // Login sayfasına yönlendir
            }
            // Model doğrulama başarısızsa aynı formu geri döndür
            TempData["msj"] = "Kayıt başarılısız! ";
            return View(user);
        }

        // Logout
        public IActionResult Logout()
        {
            TempData["SuccessMessage"] = "Başarıyla çıkış yaptınız.";
            return RedirectToAction("Login");
        }

        // Şifre Hashleme
        private string HashPassword(string password)
        {
            using (var sha256 = SHA256.Create())
            {
                var hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                return Convert.ToBase64String(hashedBytes);
            }
        }
    }
}
