using Microsoft.AspNetCore.Mvc;
using System.Linq;

using WEB.Models;

namespace WEB.Controllers
{
    public class HizmetController : Controller
    {
        private readonly BerberContext _context;

        public HizmetController(BerberContext context)
        {
            _context = context;
        }

        // GET: Hizmet
        public IActionResult Index()
        {
            var hizmetler = _context.Hizmetler.ToList(); // Veritabanındaki tüm hizmetleri alır.
            return View(hizmetler); // View'a gönderir.
        }
    }
}
