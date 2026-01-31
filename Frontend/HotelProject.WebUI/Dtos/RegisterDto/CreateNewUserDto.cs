using System.ComponentModel.DataAnnotations;

namespace HotelProject.WebUI.Dtos.RegisterDto
{
    public class CreateNewUserDto
    {
        [Required(ErrorMessage ="Ad alanı gerekli")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Soyad alanı gerekli")]
        public string Surname { get; set; }

        [Required(ErrorMessage = "Kullanıcı adı alanı gerekli")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Mail alanı gerekli")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Şifre alanı gerekli")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Şifre tekrarı alanı gerekli")]
        [Compare("Password", ErrorMessage = "Şifreler uyuşmuyor")]

        public string ConfirmPassword { get; set; }

        
    }
}
