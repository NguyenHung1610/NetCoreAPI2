using Microsoft.AspNetCore.Mvc;

namespace FirstWebMVC.Controllers
{
    public class DemoController : Controller
    { 
        public IActionResult Index()
        {
            //su dung viewbag de gui du lieu tu controller ve view
            ViewBag.FullName = "nguyen quoc hung";
            return View();
        }
        public IActionResult Demo()
        {
            return View();
        }
    }
}