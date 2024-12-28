using System.ComponentModel.DataAnnotations;

namespace Bshop.ViewModelleri
{
    public class RandevuViewModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Salon alanı gereklidir.")]
        [Display(Name = "Salon")]
        public int SalonId { get; set; }

        [Required(ErrorMessage = "Çalışan Hizmet alanı gereklidir.")]
        [Display(Name = "Çalışan Hizmet")]
        public int CalisanHizmetId { get; set; }

        [Required(ErrorMessage = "Randevu saati alanı gereklidir.")]
        [DataType(DataType.DateTime)]
        [Display(Name = "Randevu Saati")]
        public DateTime RandevuSaati { get; set; }
    }
}