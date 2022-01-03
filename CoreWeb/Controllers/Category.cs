using BusinessLayer.Concrete;
using DataAxcessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CoreWeb.Controllers
{
    public class Category : Controller
    {
        CategoryManager cm = new CategoryManager(new EfCategoryRepostory());
        public IActionResult Index()
        {
            var values = cm.GetList();
            return View(values);
        }
    }
}
