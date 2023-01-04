using Core.Entities;
using DataAccess.Contexts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NewProjectJuan.ViewModels;

namespace NewProjectJuan.Controllers
{
    public class HomeController : Controller
    {
        private AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            HomeVM homeVM = new()
            {
                SlideItems = _context.SlideItems.AsNoTracking(),
            ShippingItems = _context.ShippingItems.AsNoTracking()
            };
            return View(homeVM);
        }
    }
}
