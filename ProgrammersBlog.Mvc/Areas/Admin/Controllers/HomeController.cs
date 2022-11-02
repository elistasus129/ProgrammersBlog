using Microsoft.AspNetCore.Mvc;

namespace ProgrammersBlog.Mvc.Areas.Admin.Controlers
{
    [Area(areaName:"Admin")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
