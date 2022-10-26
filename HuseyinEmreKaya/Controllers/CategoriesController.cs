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
    }
}
