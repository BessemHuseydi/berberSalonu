using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bshop.Models
{
    public class Calisan
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Tam ad alanı gereklidir.")]
        [StringLength(100, ErrorMessage = "Tam ad en fazla 100 karakter olabilir.")]
        [Display(Name = "Tam Ad")]
        public string FullName { get; set; }

        [Required(ErrorMessage = "Salon alanı gereklidir.")]
        [Display(Name = "Salon")]
        public int SalonId { get; set; }

        // İlişki: Bir çalışan bir salona aittir
        [ForeignKey("SalonId")]
        public virtual Salon? Salon { get; set; }

        [Required(ErrorMessage = "Deneyim yılı alanı gereklidir.")]
        [Range(0, 50, ErrorMessage = "Deneyim yılı 0 ile 50 arasında olmalıdır.")]
        [Display(Name = "Deneyim Yılı")]
        public int ExperienceYears { get; set; }

        // Bir çalışanın birden fazla çalışma saati olabilir
        public virtual ICollection<CalismaSaati>? CalismaSaatleri { get; set; }

        // Çoktan çoğa ilişki: Bir çalışan birden fazla hizmet sunabilir
        public virtual ICollection<CalisanHizmet>? CalisanHizmetleri { get; set; }
    }
}
