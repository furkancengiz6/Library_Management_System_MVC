var builder = WebApplication.CreateBuilder(args);

//Controller kullanılacağını ve View döneceğini belirtildi.
builder.Services.AddControllersWithViews();

var app = builder.Build();

//wwwroot
app.UseStaticFiles();

//Varsayılan route belirtildi.// Home/Index
app.MapDefaultControllerRoute();

app.Run();
