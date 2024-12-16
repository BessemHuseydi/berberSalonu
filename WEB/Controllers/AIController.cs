using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

public class AIController : Controller
{
    private readonly IHttpClientFactory _httpClientFactory;

    public AIController(IHttpClientFactory httpClientFactory)
    {
        _httpClientFactory = httpClientFactory;
    }

    // AI önerileri almak için POST metodu
    [HttpPost]
    public async Task<IActionResult> GetSuggestions(IFormFile fileUpload)
    {
        if (fileUpload == null || fileUpload.Length == 0)
        {
            // Dosya yüklenmediyse uyarı mesajı göster
            ViewBag.Suggestions = "Lütfen geçerli bir fotoğraf yükleyin.";
            return View();
        }

        try
        {
            // API'ye gönderilecek form verisini hazırlıyoruz
            var formData = new MultipartFormDataContent();
            using (var stream = new MemoryStream())
            {
                await fileUpload.CopyToAsync(stream);
                formData.Add(new ByteArrayContent(stream.ToArray()), "file", fileUpload.FileName);

                // RapidAPI veya başka bir AI API'ye istek gönderiyoruz
                var client = _httpClientFactory.CreateClient();
                var response = await client.PostAsync("https://rapidapi.com/your-api-endpoint", formData);

                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    // API'den dönen sonucu kullanıcıya gösteriyoruz
                    ViewBag.Suggestions = content;
                }
                else
                {
                    ViewBag.Suggestions = "Yapay zeka önerilerini almakta bir hata oluştu.";
                }
            }
        }
        catch (Exception ex)
        {
            ViewBag.Suggestions = $"Hata oluştu: {ex.Message}";
        }

        return View();
    }
}
