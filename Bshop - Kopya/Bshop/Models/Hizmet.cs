using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bshop.Models
{
    public class Hizmet
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Hizmet adı alanı gereklidir.")]
        [StringLength(100, ErrorMessage = "Hizmet adı en fazla 100 karakter olabilir.")]
        [Display(Name = "Hizmet Adı")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Açıklama alanı gereklidir.")]
        [StringLength(500, ErrorMessage = "Açıklama en fazla 500 karakter olabilir.")]
        [Display(Name = "Açıklama")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Süre alanı gereklidir.")]
        [Range(1, 1000, ErrorMessage = "Süre 1 ile 1000 arasında bir değer olmalıdır.")]
        [Display(Name = "Süre (dk)")]
        public int DurationMinutes { get; set; }

        [Required(ErrorMessage = "Fiyat alanı gereklidir.")]
        [Range(0.01, double.MaxValue, ErrorMessage = "Fiyat pozitif bir değer olmalıdır.")]
        [DataType(DataType.Currency)]
        [Display(Name = "Fiyat")]
        public decimal Price { get; set; }

        [Required(ErrorMessage = "Fotoğraf URL'si alanı gereklidir.")]
        [Url(ErrorMessage = "Geçerli bir URL giriniz.")]
        [Display(Name = "Fotoğraf URL'si")]
        public string ? PhotoUrl { get; set; }

        // Çoktan çoğa ilişki: Bir hizmeti birden fazla çalışan sunabilir
        public virtual ICollection<CalisanHizmet>? CalisanHizmetleri { get; set; }
    }
}
