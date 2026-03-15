using Demo_Product.Models;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Demo_Product.Controllers
{
    public class RegisterController : Controller
    {
        private readonly UserManager<AppUser> _userManager;  //bu usermanager register işlemi için kullanılacak

        public RegisterController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(UserRegisterViewModel model)
        {
            AppUser appUser = new AppUser()    //oluşturduğumuz appuser sınıfından bir nesne oluşturduk ve bu nesneye kolay yoldan boyle atama yaptık
            {
                Name = model.Name,         // bizim tanımladıklarımız
                Surname = model.Surname,
                UserName = model.UserName,   // identity userdan gelir
                Email = model.Mail          // identity userdan gelir
            };

            if (model.Password == model.ConfirmPassword)
            {
                var result = await _userManager.CreateAsync(appUser, model.Password);   // create async hesap oluşturma işlemidir. bizden iki parametre ister. birincide user, ikincide password ister biz AppUser sınıfından oluşturduğumuz appUser nesnesine atamalarımızı yapmıştık onu ekledik ve ikinci parametre olarakta passwordu ekledik
                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Login");
                }
                else
                {
                    foreach (var item in result.Errors)
                    {
                        ModelState.AddModelError("", item.Description);  //hata mesajlarını ekrana yazdırmak için
                    }
                }
            }
            return View(model);
        }
    }
}
/*
 * Identity kütüphanesi şifre şartları:
 * 6 Karakter
 * 1 tane küçük harf
 * 1 tane büyük harf
 * 1 tane sembol
 * yoksa register yapılamaz
 */ 