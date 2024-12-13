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

        // Sign Up - GET
        [HttpGet]
        public IActionResult SignUp()
        {
            return View();
        }

        // Sign Up - POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult SignUp(User model)
        {
            if (ModelState.IsValid)
            {
                // Kullanıcı zaten mevcut mu kontrol et
                if (_context.Users.Any(u => u.Email == model.Email))
                {
                    ModelState.AddModelError("Email", "Bu e-posta adresiyle kayıtlı bir kullanıcı zaten var.");
                    return View(model);
                }

                // Şifreyi hashle
                model.PasswordHash = HashPassword(model.PasswordHash);

                // Kullanıcıyı veritabanına ekle
                _context.Users.Add(model);
                _context.SaveChanges();

                TempData["SuccessMessage"] = "Kayıt başarılı! Giriş yapabilirsiniz.";
                return RedirectToAction("Login");
            }

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
        public IActionResult Login(string email, string password)
        {
            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                ModelState.AddModelError("", "E-posta ve şifre gereklidir.");
                return View();
            }

            // Kullanıcıyı kontrol et
            var user = _context.Users.FirstOrDefault(u => u.Email == email);
            if (user == null || user.PasswordHash != HashPassword(password))
            {
                ModelState.AddModelError("", "Geçersiz e-posta veya şifre.");
                return View();
            }

            // Kullanıcıyı oturumda sakla
            TempData["SuccessMessage"] = $"Hoşgeldiniz, {user.Name}!";
            return RedirectToAction("Index", "Home");
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
