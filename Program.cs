var builder = WebApplication.CreateBuilder(args);

//Controller kullan�laca��n� ve View d�nece�ini belirtildi.
builder.Services.AddControllersWithViews();

var app = builder.Build();

//Varsay�lan route belirtildi.// Home/Index
app.MapDefaultControllerRoute();

app.Run();
