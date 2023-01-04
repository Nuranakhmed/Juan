using DataAccess.Contexts;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

var connectionstr = builder.Configuration["ConnectionStrings:Default"];
builder.Services.AddDbContext<AppDbContext>(opt =>
{
    opt.UseSqlServer(connectionstr);
});



var app = builder.Build();
app.UseStaticFiles();


app.MapControllerRoute(
    name: "juan",
    pattern: "{controller=Home}/{action=Index}/{Id?}"
    );
app.MapControllerRoute(
     name: "areas",
     pattern: "{area:exists}/{controller=Dashboard}/{action=Index}/{id?}"
          );
app.Run();

