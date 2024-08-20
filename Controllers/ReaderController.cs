using Microsoft.AspNetCore.Mvc;

namespace MyWebtoon.Controllers
{
    public class ReaderController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
