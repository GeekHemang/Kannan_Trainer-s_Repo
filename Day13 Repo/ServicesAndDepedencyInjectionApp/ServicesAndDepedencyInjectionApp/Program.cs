var builder = WebApplication.CreateBuilder(args);

//registrer services

builder.Services.AddControllersWithViews();

var app = builder.Build();

//register middleware;

//app.UseDefaultFiles();
app.UseStaticFiles();
app.MapDefaultControllerRoute();

app.Run();
