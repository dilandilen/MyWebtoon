using Microsoft.AspNetCore.Mvc;

namespace MyWebtoon.Controllers
{
    public class WebtoonController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
