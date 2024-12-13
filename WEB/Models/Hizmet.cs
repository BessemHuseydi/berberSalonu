using System.ComponentModel.DataAnnotations;

namespace WEB.Models
{
    public class Hizmet
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Hizmet adı gereklidir.")]
        [StringLength(100, ErrorMessage = "Hizmet adı en fazla 100 karakter olabilir.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Hizmet süresi gereklidir.")]
        [Range(1, 1440, ErrorMessage = "Hizmet süresi 1 ile 1440 dakika arasında olmalıdır.")]
        public int DurationMinutes { get; set; }

        [Required(ErrorMessage = "Fiyat gereklidir.")]
        [Range(0.0, 10000.0, ErrorMessage = "Fiyat 0 ile 10.000 arasında olmalıdır.")]
        public decimal Price { get; set; }

        // Fotoğraf Yolu
        [StringLength(255, ErrorMessage = "Fotoğraf yolu en fazla 255 karakter olabilir.")]
        public string? PhotoPath { get; set; } // Nullable özelliği
    }
}
