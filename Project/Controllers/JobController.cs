using BussinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Project.Controllers
{
    public class JobController : Controller
    {
        JobManager jobManager = new JobManager(new EfJobDal());
        public IActionResult Index()
        {
            var values = jobManager.TGetList();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddJob()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddJob(Job p)      //EntitYLayer Concrete den Product p aldık
        {
            jobManager.TInsert(p);
            return RedirectToAction("Index");
        }
        public IActionResult DeleteJob(int id)
        {
            var value = jobManager.TGetById(id);
            jobManager.TRemove(value);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult UpdateJob(int id)         //Güncelleme yapılacak alanı buldurduk
        {
            var value = jobManager.TGetById(id);
            return View(value);
        }
        [HttpPost]
        public IActionResult UpdateJob(Job p)       // Güncelleme işlemini yapıcaz
        {
            jobManager.TUpdate(p);
            return RedirectToAction("Index");
        }
    }
}
