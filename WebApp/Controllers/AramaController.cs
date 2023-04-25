using BAL.Concrete;
using BAL.Fluent;
using DAL.Concrete;
using DAL.EntityFramework;
using Entity.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace WebApp.Controllers
{
    
    public class AramaController : Controller
    {
        static Context context = new Context();
        static AramaManager aramaManager = new AramaManager(new EFaramaDAL());
        static AramaTipiManager aramaTipiManager = new AramaTipiManager(new EFaramatipiDAL());
        static ArayanTipiManager arayanTipiManager = new ArayanTipiManager(new EFarayantipiDAL());

        List<SelectListItem> values_arama = (from x in aramaTipiManager.GetListAll()
                                             select new SelectListItem
                                             {
                                                 Text = x.Aramatipi,
                                                 Value = x.AramaTipiId.ToString()
                                             }).ToList();
        List<SelectListItem> values_arayan = (from x in arayanTipiManager.GetListAll()
                                              select new SelectListItem
                                              {
                                                  Text = x.Arayantipi,
                                                  Value = x.ArayanTipiId.ToString()
                                              }).ToList();
        List<SelectListItem> users = (from user in context.Users
                     select new SelectListItem
                     {
                         Value = user.Id.ToString(),
                         Text = user.Name,

                     }).ToList();

        public IActionResult Index()
        {
            var values = aramaManager.GetListAll();
            return View(values);
        }
        [HttpGet]
        public IActionResult AramaEkle()
        {            
            ViewBag.User = users;
            ViewBag.AramaTipleri = values_arama;
            ViewBag.ArayanTipleri = values_arayan;
            return View();
        }
        [HttpPost]
        public IActionResult AramaEkle(Arama a)
        {
            ViewBag.User = users;
            ViewBag.AramaTipleri = values_arama;
            ViewBag.ArayanTipleri = values_arayan;
            AramaValidator aramavalidator = new AramaValidator();
            ValidationResult result = aramavalidator.Validate(a);
            if (result.IsValid){
                aramaManager.TInsert(a);
                return RedirectToAction("", "Home");
            }
            else
            {

                foreach (var item in result.Errors)
                {                    
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }                
            }
            return View();
            
        }
        [HttpGet]
        public IActionResult AramaDuzenle(int id)
        {            
            ViewBag.User = users;
            ViewBag.AramaTipleri = values_arama;
            ViewBag.ArayanTipleri = values_arayan;
            var value = context.Arama.Where(x => x.AramaId == id).FirstOrDefault();
            return View(value);
        }
        [HttpPost]
        public IActionResult AramaDuzenle(Arama a)
        {
            aramaManager.TUpdate(a);
            return RedirectToAction("Index");
        }
    }
}
