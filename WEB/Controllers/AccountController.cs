using Microsoft.AspNetCore.Mvc;
using WEB.Models;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using Microsoft.AspNetCore.Authentication;

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
                    // Başarılı kayıt mesajı
                    TempData["msj"] = "Bu e-posta adresiyle kayıtlı bir kullanıcı zaten var.";
                    return View("SignUp"); // Aynı view'e geri dön
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
            return View("SignUp");
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

        // Login - POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult UsrLogin222(User u)
        {
            // Kullanıcı zaten giriş yapmış mı kontrol et
            if (HttpContext.Session.GetString("Name") != null)
            {
                TempData["msj"] = "Zaten giriş yaptınız. Önce çıkış yapmalısınız.";
                return RedirectToAction("Login");
            }

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
            HttpContext.Session.SetString("Name", user.Name); // Kullanıcı adı session'a kaydedilir
            TempData["UserName"] = user.Name;

            
            return View("Welcome");
        }


        public IActionResult Logout()
        {
            HttpContext.Session.Clear(); // Tüm session verilerini temizler
            TempData["msj"] = "Başarıyla çıkış yaptınız.";
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
