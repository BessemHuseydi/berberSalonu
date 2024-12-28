using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Bshop.Data;

namespace Bshop.Models
{
    public class CalismaSaati : IValidatableObject
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Çalışan alanı gereklidir.")]
        [Display(Name = "Çalışan")]
        public int CalisanId { get; set; }

        // Navigasyon Özelliği
        [ForeignKey("CalisanId")]
        public virtual Calisan? Calisan { get; set; }

        [Required(ErrorMessage = "Gün alanı gereklidir.")]
        [Display(Name = "Gün")]
        public DayOfWeek Gun { get; set; }

        [Required(ErrorMessage = "Başlangıç saati gereklidir.")]
        [DataType(DataType.Time)]
        [Display(Name = "Başlangıç Saati")]
        public TimeSpan BaslangicSaati { get; set; }

        [Required(ErrorMessage = "Bitiş saati gereklidir.")]
        [DataType(DataType.Time)]
        [Display(Name = "Bitiş Saati")]
        public TimeSpan BitisSaati { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (BitisSaati <= BaslangicSaati)
            {
                yield return new ValidationResult("Bitiş saati, başlangıç saatinden büyük olmalıdır.", new[] { "BitisSaati" });
            }

            // Aynı gün için çakışan saatleri kontrol et
            var dbContext = (ApplicationDbContext)validationContext.GetService(typeof(ApplicationDbContext));
            var existingEntries = dbContext.CalismaSaatis
                .Where(cs => cs.CalisanId == CalisanId && cs.Gun == Gun && cs.Id != Id)
                .ToList();

            foreach (var entry in existingEntries)
            {
                // Zaman çakışmalarını kontrol edin
                if ((BaslangicSaati >= entry.BaslangicSaati && BaslangicSaati < entry.BitisSaati) ||
                    (BitisSaati > entry.BaslangicSaati && BitisSaati <= entry.BitisSaati))
                {
                    yield return new ValidationResult("Çalışma saatleri çakışmaktadır.", new[] { "BaslangicSaati", "BitisSaati" });
                }
            }
        }
    }
}
