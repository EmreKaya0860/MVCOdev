using Microsoft.AspNetCore.Mvc;

namespace HuseyinEmreKaya.Controllers
{
    public class ProductsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Televizyon()
        {
            return View();
        }
    }
}
