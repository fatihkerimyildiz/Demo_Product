using System.ComponentModel.DataAnnotations;

namespace Demo_Product.Models
{
    public class UserLoginViewModel
    {
        [Required(ErrorMessage = "Lutfen Kulllanıcı Adınızı Giriniz")]
        public string UserName { get; set; }    

        [Required(ErrorMessage = "Lutfen Şifrenizi Giriniz")]
        public string Password { get; set; }
    }
}
