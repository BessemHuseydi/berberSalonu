using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bshop.Models
{
    public class Randevu
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Kullanıcı alanı gereklidir.")]
        [Display(Name = "Kullanıcı")]
        public int UserId { get; set; }

        // Navigasyon Özelliği
        [ForeignKey("UserId")]
        public virtual User ?User { get; set; }

        [Required(ErrorMessage = "Salon alanı gereklidir.")]
        [Display(Name = "Salon")]
        public int SalonId { get; set; }

        // Navigasyon Özelliği
        [ForeignKey("SalonId")]
        public virtual Salon? Salon { get; set; }

        [Required(ErrorMessage = "Çalışan Hizmet alanı gereklidir.")]
        [Display(Name = "Çalışan Hizmet")]
        public int CalisanHizmetId { get; set; }

        // Navigasyon Özelliği
        [ForeignKey("CalisanHizmetId")]
        public virtual CalisanHizmet? CalisanHizmet { get; set; }

        [Required(ErrorMessage = "Randevu saati alanı gereklidir.")]
        [DataType(DataType.DateTime)]
        [Display(Name = "Randevu Saati")]
        public DateTime RandevuSaati { get; set; }

        [Required]
        [Display(Name = "Onaylandı")]
        public bool Onaylandi { get; set; } = false;
    }
}
