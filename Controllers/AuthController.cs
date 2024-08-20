using Microsoft.AspNetCore.Mvc;

namespace MyWebtoon.Controllers
{
    public class AuthController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
