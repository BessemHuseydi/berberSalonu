using System.ComponentModel.DataAnnotations;

namespace WEB.Models
{
    public class Calisan
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Çalışan adı gereklidir.")]
        [StringLength(100, ErrorMessage = "Çalışan adı en fazla 100 karakter olabilir.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Salon ID gereklidir.")]
        public int SalonId { get; set; }

        [Required(ErrorMessage = "Pozisyon gereklidir.")]
        [StringLength(50, ErrorMessage = "Pozisyon bilgisi en fazla 50 karakter olabilir.")]
        public string Position { get; set; }

        [Required(ErrorMessage = "Deneyim yılı gereklidir.")]
        [Range(0, 50, ErrorMessage = "Deneyim yılı 0 ile 50 arasında olmalıdır.")]
        public int ExperienceYears { get; set; }

        // Navigation Properties
        public Salon Salon { get; set; }
        public ICollection<CalismaSaati> CalismaSaatleri { get; set; }
    }

}
