using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Bshop.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Bshop.ViewModelleri
{
    public class CalisanListViewModel
    {
        public List<Salon> Salons { get; set; }
        public List<Hizmet> Hizmets { get; set; }

        [Display(Name = "Salon")]
        public int? SelectedSalonId { get; set; }

        [Display(Name = "Hizmet")]
        public int? SelectedHizmetId { get; set; }

        public List<Calisan> Calisans { get; set; }
    }
}
