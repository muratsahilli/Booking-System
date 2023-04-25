using BAL.Concrete;
using DAL.Concrete;
using DAL.EntityFramework;
using Entity.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Diagnostics;
using WebApp.Models;

namespace WebApp.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        Context context = new Context();
        
        private readonly ILogger<HomeController> _logger;
        
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        public IActionResult Index()
        {
            string all = context.Randevu.Count().ToString();

            string today = context.Randevu.Where(x => x.StartTime > DateTime.Today).Count().ToString();
            string calls = context.Arama.Count().ToString();
            string[] list = { all,today,calls };
            ViewBag.numList = list;
            return View();
        }
        

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        public IActionResult Datetime()
        {

            return View();
        }
        public IActionResult AddDatetime()
        {

            return View();
        }
    }
}