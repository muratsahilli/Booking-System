using BAL.Concrete;
using BAL.Fluent;
using DAL.Concrete;
using DAL.EntityFramework;
using Entity.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace WebApp.Controllers
{
    public class RandevuController : Controller
    {
        static Context context = new Context();
        RandevuManager randevuManager = new RandevuManager(new EFrandevuDAL());
        static RandevuDurumuManager randevudurumuManager = new RandevuDurumuManager(new EFrandevudurumuDAL());
        List<SelectListItem> values_randur = (from x in randevudurumuManager.GetListAll()
                                              select new SelectListItem
                                              {
                                                  Text = x.Randevudurumu,
                                                  Value = x.RandevuID.ToString()
                                              }).ToList();
        List<SelectListItem> users = (from user in context.Users
                                      select new SelectListItem
                                      {
                                          Value = user.Id.ToString(),
                                          Text = user.Name,

                                      }).ToList();
        
        public IActionResult Index()
        {
            var values = randevuManager.GetListAll();
            return View(values);
        }
        [HttpGet]
        public IActionResult RandevuEkle()
        {

            ViewBag.User = users;
            ViewBag.randur = values_randur;

            return View();
        }

        [HttpPost]
        public IActionResult RandevuEkle(Randevular r)
        {
            RandevuValidator randevuValidator = new RandevuValidator();
            ValidationResult results = randevuValidator.Validate(r);
            if (results.IsValid)
            {
                randevuManager.TInsert(r);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in results.Errors)
                {
                    ViewBag.User = users;
                    ViewBag.randur = values_randur;
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();

        }
        [HttpGet]
        public IActionResult RandevuDuzenle(int id)
        {
            ViewBag.User = users;
            ViewBag.randur = values_randur;
            var values = randevuManager.GetById(id);
            return View(values);
        }

        [HttpPost]
        public IActionResult RandevuDuzenle(Randevular r)
        {
            randevuManager.TUpdate(r);
            return RedirectToAction("Index");
        }
        
        public IActionResult RandevuSil(int id)
        {
            var values = randevuManager.GetById(id);
            randevuManager.TUpdate(values);
            return RedirectToAction("Index");
        }

        public IActionResult Privacy()
        {
            return View();
        }
    }
}
