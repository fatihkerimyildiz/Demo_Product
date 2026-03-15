using BussinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Project.Controllers
{
    public class ProductController : Controller
    {
        ProductManager productManager = new ProductManager(new EfProductDal());
        public IActionResult Index()
        {
            var values = productManager.TGetList();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddProduct()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddProduct(Product p)      //EntitYLayer Concrete den Product p aldık
        {
            productManager.TInsert(p);
            return RedirectToAction("Index");
        }
        public IActionResult DeleteProduct(int id)
        {
            var value = productManager.TGetById(id);
            productManager.TRemove(value);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult UpdateProduct(int id)         //Güncelleme yapılacak alanı buldurduk
        {
            var value=productManager.TGetById(id);
            return View(value);
        }
        [HttpPost]
        public IActionResult UpdateProduct(Product p)       // Güncelleme işlemini yapıcaz
        {
            productManager.TUpdate(p);
            return RedirectToAction("Index");
        }
    }
}
