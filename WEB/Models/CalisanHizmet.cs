
using System.ComponentModel.DataAnnotations;

namespace WEB.Models
{
    public class CalisanHizmet
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Çalışan ID gereklidir.")]
        public int CalisanId { get; set; }

        [Required(ErrorMessage = "Hizmet ID gereklidir.")]
        public int HizmetId { get; set; }

        // Navigation Properties
        public Calisan Calisan { get; set; }
        public Hizmet Hizmet { get; set; }
    }
}


