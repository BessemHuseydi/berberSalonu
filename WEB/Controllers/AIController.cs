using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
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

                // HttpClient ile API'ye istek gönderiyoruz
                var client = _httpClientFactory.CreateClient();
                var request = new HttpRequestMessage
                {
                    Method = HttpMethod.Post,
                    RequestUri = new Uri("https://hairstyle-changer.p.rapidapi.com/huoshan/facebody/hairstyle"),
                    Headers =
                    {
                        { "x-rapidapi-key", "fec9ad15aemshc2ae80c3df78615p1d06b7jsnbebd84383e47" }, // RapidAPI Key
                        { "x-rapidapi-host", "hairstyle-changer.p.rapidapi.com" }, // RapidAPI Host
                    },
                    Content = formData,
                };

                using (var response = await client.SendAsync(request))
                {
                    response.EnsureSuccessStatusCode();
                    var body = await response.Content.ReadAsStringAsync();
                    // API'den dönen sonucu kullanıcıya gösteriyoruz
                    ViewBag.Suggestions = body;
                }
            }
        }
        catch (Exception ex)
        {
            ViewBag.Suggestions = $"Hata oluştu: {ex.Message}";
        }

        return View("AI");
    }
}
