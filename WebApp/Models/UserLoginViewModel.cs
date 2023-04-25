using System.ComponentModel.DataAnnotations;

namespace WebApp.Models
{
    public class UserLoginViewModel
    {
        [Required(ErrorMessage ="Kullanıcı adı boş geçilemez")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Şifre boş geçilemez")]
        public string Password { get; set; }
    }
}
