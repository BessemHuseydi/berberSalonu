using System.ComponentModel.DataAnnotations;

namespace WEB.Models
{
    public class Salon
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Salon adı gereklidir.")]
        [StringLength(100, ErrorMessage = "Salon adı en fazla 100 karakter olabilir.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Lokasyon gereklidir.")]
        [StringLength(200, ErrorMessage = "Lokasyon bilgisi en fazla 200 karakter olabilir.")]
        public string Location { get; set; }

        [Required(ErrorMessage = "İletişim numarası gereklidir.")]
        [Phone(ErrorMessage = "Geçerli bir iletişim numarası giriniz.")]
        public string ContactNumber { get; set; }

        // Navigation Properties
        public ICollection<Randevu>? Randevular { get; set; }
        public ICollection<Calisan>? Calisanlar { get; set; }
    }

}
