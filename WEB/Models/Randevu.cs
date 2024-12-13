using System.ComponentModel.DataAnnotations;

namespace WEB.Models
{
    public class Randevu
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Kullanıcı ID gereklidir.")]
        public int UserId { get; set; }

        [Required(ErrorMessage = "Salon ID gereklidir.")]
        public int SalonId { get; set; }

        [Required(ErrorMessage = "Randevu zamanı gereklidir.")]
        public DateTime AppointmentTime { get; set; }

        [Required(ErrorMessage = "Hizmet bilgisi gereklidir.")]
        [StringLength(100, ErrorMessage = "Hizmet bilgisi en fazla 100 karakter olabilir.")]
        public string Service { get; set; }

        [Required(ErrorMessage = "Fiyat gereklidir.")]
        [Range(0.0, 10000.0, ErrorMessage = "Fiyat 0 ile 10.000 arasında olmalıdır.")]
        public decimal Price { get; set; }

        // Navigation Properties
        public User User { get; set; }
        public Salon Salon { get; set; }
    }

}
