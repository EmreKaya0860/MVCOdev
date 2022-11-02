using Microsoft.AspNetCore.Mvc;

namespace HuseyinEmreKaya.Controllers
{
    public class CategoriesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Bilgisayar()
        {
            return View();
        }
        public IActionResult Tablet()
        {
            return View();
        }
        public IActionResult Telefon()
        {
            return View();
        }
    }
}
