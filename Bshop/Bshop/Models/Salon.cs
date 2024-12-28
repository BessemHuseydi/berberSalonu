using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Bshop.Models
{
    public class Salon
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Salon adı gereklidir.")]
        [StringLength(100, ErrorMessage = "Salon adı en fazla 100 karakter olabilir.")]
        [Display(Name = "Salon Adı")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Konum alanı gereklidir.")]
        [StringLength(200, ErrorMessage = "Konum en fazla 200 karakter olabilir.")]
        [Display(Name = "Konum")]
        public string Location { get; set; }

        [Required(ErrorMessage = "İletişim numarası gereklidir.")]
        [Phone(ErrorMessage = "Geçerli bir telefon numarası giriniz.")]
        [Display(Name = "İletişim Numarası")]
        public string ContactNumber { get; set; }

        // Bir salonun birden fazla çalışanı olabilir
        public virtual ICollection<Calisan>? Calisans { get; set; }
    }
}
