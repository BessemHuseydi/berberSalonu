using Microsoft.AspNetCore.Mvc;
using System.Net.Mail;

namespace Bshop.Controllers
{
    public class ContactController : Controller
    {
        [HttpGet]
        public IActionResult Contact()
        {

            // İletişim formu sayfasını döndür
            return View();

        }
        public IActionResult Contact2()
        {

            // İletişim formu sayfasını döndür
            return View();

        }
        [HttpPost]
        public IActionResult SendMessage(string name, string email, string message)
        {
            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(message))
            {
                TempData["Message"] = "All fields are required. Please fill out the form completely.";
                return RedirectToAction("Contact");
            }

            try
            {
                // E-posta mesajını oluştur
                MailMessage mail = new MailMessage
                {
                    From = new MailAddress("bessem0987@gmail.com"), // Gönderen adresi
                    Subject = "New Contact Form Message",
                    Body = $"Name: {name}\nEmail: {email}\nMessage:\n{message}"
                };

                // Alıcı adresi
                mail.To.Add("bessem0987@gmail.com");

                // SMTP sunucusu ayarları
                using (SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587))
                {
                    smtp.Credentials = new System.Net.NetworkCredential("bessem0987@gmail.com", "bessem2123");
                    smtp.EnableSsl = true;

                    // E-postayı gönder
                    smtp.Send(mail);
                }

                // Başarı mesajı
                TempData["Message"] = "Your message has been sent successfully!";
            }
            catch (Exception ex)
            {
                // Hata mesajı
                TempData["Message"] = $"An error occurred while sending your message. Please try again later. Error: {ex.Message}";
            }

            // İletişim sayfasına yönlendir
            return RedirectToAction("Contact2");
        }
    }
}
