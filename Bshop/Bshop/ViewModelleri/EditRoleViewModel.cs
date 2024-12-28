using Bshop.Models;
using System.ComponentModel.DataAnnotations;

public class EditRoleViewModel
{
    public int Id { get; set; }

    public string ? FullName { get; set; } // To display the user's name

    [Required(ErrorMessage = "Rol alanı gereklidir.")]
    [Display(Name = "Rol")]
    public UserRole Role { get; set; }
}
