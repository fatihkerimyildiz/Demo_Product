using System.ComponentModel.DataAnnotations;

namespace Demo_Product.Models
{
    public class UserRegisterViewModel
    {
        [Required(ErrorMessage ="Lutfen isinizi giriniz")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Lutfen soyisminizi giriniz")]
        public string Surname { get; set; }

        [Required(ErrorMessage = "Lutfen kullanıcı adınızı giriniz")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Lutfen mail adresinizi giriniz")]
        public string Mail { get; set; }

        [Required(ErrorMessage = "Lutfen şifrenizi giriniz")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Lutfen şifrenizi doğrulayınız")]
        [Compare("Password", ErrorMessage ="Şifreler uyuşmuyor")]
        public string ConfirmPassword { get; set; }

    }
}
