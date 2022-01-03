using Microsoft.AspNetCore.Mvc;

namespace CoreWeb.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
