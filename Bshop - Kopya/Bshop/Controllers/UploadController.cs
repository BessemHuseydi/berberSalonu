using Microsoft.AspNetCore.Mvc;
using System.IO;
using System.Threading.Tasks;

namespace Bshop.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UploadController : ControllerBase
    {
        [HttpPost("upload")]
        public async Task<IActionResult> UploadPhoto([FromForm] IFormFile photo)
        {
            if (photo == null || photo.Length == 0)
                return BadRequest("No file uploaded.");

            // Fotoğrafı bir geçici klasöre kaydediyoruz
            var filePath = Path.Combine(Path.GetTempPath(), photo.FileName);
            using (var stream = new FileStream(filePath, FileMode.Create))
            {
                await photo.CopyToAsync(stream);
            }

            // Burada fotoğrafı bir makine öğrenimi modeline gönderdiğinizi varsayın
            // Dummy yanıtı (örneğin, analiz sonucu):
            var result = new
            {
                HairColor = "Blonde",
                HairStyle = "Curly"
            };

            // Analiz sonucunu döndürüyoruz
            return Ok(result);
        }
    }
}
