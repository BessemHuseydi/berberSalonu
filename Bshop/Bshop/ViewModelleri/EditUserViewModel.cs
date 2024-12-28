using Bshop.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace Bshop.ViewModelleri
{
    public class EditUserViewModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Tam ad alanı gereklidir.")]
        [StringLength(100, ErrorMessage = "Tam ad en fazla 100 karakter olabilir.")]
        [Display(Name = "Tam Ad")]
        public string FullName { get; set; }

        [Required(ErrorMessage = "Telefon alanı gereklidir.")]
        [Phone(ErrorMessage = "Geçerli bir telefon numarası giriniz.")]
        [Display(Name = "Telefon")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Email alanı gereklidir.")]
        [EmailAddress(ErrorMessage = "Geçerli bir email adresi giriniz.")]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Şifre alanı gereklidir.")]
        [DataType(DataType.Password)]
        [StringLength(100, MinimumLength = 6, ErrorMessage = "Şifre en az 6 karakter olmalıdır.")]
        [Display(Name = "Şifre")]
        public string Password { get; set; }

        [Required]
        [Display(Name = "Rol")]
        public UserRole Role { get; set; }

        public IEnumerable<SelectListItem> Roles { get; set; }
    }
}