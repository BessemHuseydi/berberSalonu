using System.ComponentModel.DataAnnotations;

namespace WEB.Models
{
    public class rr
    {
        public int Id { get; set; }

      
        public int UserId { get; set; }

        
        public int SalonId { get; set; }


        public int HizmetId { get; set; }

        [Required(ErrorMessage = "Randevu zamanı gereklidir.")]
        public DateTime AppointmentTime { get; set; }

        [Required(ErrorMessage = "Fiyat gereklidir.")]
        [Range(0.0, 10000.0, ErrorMessage = "Fiyat 0 ile 10.000 arasında olmalıdır.")]
        public decimal Price { get; set; }

        // Navigation Properties
        public User User { get; set; }
        public Salon Salon { get; set; }
        public Hizmet Hizmet { get; set; }
    }
}
