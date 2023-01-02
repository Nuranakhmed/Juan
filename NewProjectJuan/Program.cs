var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

var app = builder.Build();
app.UseStaticFiles();
app.MapControllerRoute(
    name: "juan",
    pattern: "{controller=Home}/{action=Index}/{Id?}");

app.Run();


