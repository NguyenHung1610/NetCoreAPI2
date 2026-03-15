using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;
namespace Lesson6.Controllers
{
    public class DemoController : Controller
    {
        // GET: /Demo/
        public IActionResult Index()
        {
            return View();
        }
           [HttpPost]
        public IActionResult Index(string FullName)
        {
            ViewBag.Name = "Hello " + FullName;
            return View();
        }
        public IActionResult Test()
        {
            return View();
        }
    }
}