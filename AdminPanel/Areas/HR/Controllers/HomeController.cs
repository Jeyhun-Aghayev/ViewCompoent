using Microsoft.AspNetCore.Mvc;

namespace CSharp.ViewComponentTask.Areas.HR.Controllers
{

    [Area("HR")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
