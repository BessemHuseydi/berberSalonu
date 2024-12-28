using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bshop.Models
{
    public class CalisanHizmet
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int CalisanId { get; set; }

        [Required]
        public int HizmetId { get; set; }

        // Navigasyon Özellikleri
        [ForeignKey("CalisanId")]
        public virtual Calisan? Calisan { get; set; }

        [ForeignKey("HizmetId")]
        public virtual Hizmet? Hizmet { get; set; }

        // Ekstra Alanlar (İsteğe Bağlı)
        // Örneğin, hizmetin başlangıç tarihi veya notlar gibi
        // public DateTime StartDate { get; set; }
        // public string Notes { get; set; }
    }
}
