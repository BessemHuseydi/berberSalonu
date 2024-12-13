using System.ComponentModel.DataAnnotations;

namespace WEB.Models
{
    public class CalismaSaati
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Çalışan ID gereklidir.")]
        public int CalisanId { get; set; }

        [Required(ErrorMessage = "Haftanın günü gereklidir.")]
        [StringLength(15, ErrorMessage = "Haftanın günü bilgisi en fazla 15 karakter olabilir.")]
        public string DayOfWeek { get; set; }

        [Required(ErrorMessage = "Başlangıç saati gereklidir.")]
        public TimeSpan StartTime { get; set; }

        [Required(ErrorMessage = "Bitiş saati gereklidir.")]
        public TimeSpan EndTime { get; set; }

        // Navigation Property
        public Calisan Calisan { get; set; }
    }

}
