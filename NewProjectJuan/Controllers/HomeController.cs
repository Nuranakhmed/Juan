using Microsoft.AspNetCore.Mvc;

namespace NewProjectJuan.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
