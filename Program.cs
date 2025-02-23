var builder = WebApplication.CreateBuilder(args);

//Controller kullanýlacaðýný ve View döneceðini belirtildi.
builder.Services.AddControllersWithViews();

var app = builder.Build();

//Varsayýlan route belirtildi.// Home/Index
app.MapDefaultControllerRoute();

app.Run();
