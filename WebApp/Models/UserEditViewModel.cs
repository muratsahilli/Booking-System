using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace WebApp.Models
{
    public class UserEditViewModel
    {
        [Required(ErrorMessage = "Lütfen adınızı giriniz..")]
        public string Name { get; set; } = null!;
        [Required(ErrorMessage = "Lütfen soy adınızı giriniz..")]
        public string SurName { get; set; } = null!;

        [Required(ErrorMessage = "Lütfen şifrenizi giriniz..")]
        public string Password { get; set; } = null!;

        [Required(ErrorMessage = "Lütfen şifrenizi aynı giriniz..")]
        [Compare("Password", ErrorMessage = "Lütfen şifrenizi aynı giriniz..")]
        public string ConfirmPassword { get; set; } = null!;
    }
}
