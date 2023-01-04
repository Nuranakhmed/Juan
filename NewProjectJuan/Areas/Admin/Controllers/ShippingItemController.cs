using DataAccess.Contexts;
using Microsoft.AspNetCore.Mvc;

namespace NewProjectJuan.Areas.Admin.Controllers;
[Area("Admin")]
public class ShippingItemController : Controller
{
   
    private AppDbContext _context;

    public ShippingItemController(AppDbContext context)
    {
        _context = context;
    }

    public IActionResult Index()
    {
        return View(_context.ShippingItems);
    }
}
