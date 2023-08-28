using Microsoft.EntityFrameworkCore;
using WebNotas.Models;

var webAppSitio = WebApplication.CreateBuilder(args);

var configuration = new ConfigurationBuilder()
        .AddJsonFile("appsettings.json")
        .Build();
// Add services to the container.

webAppSitio.Services.AddControllersWithViews();
webAppSitio.Services.AddDbContext<WebNotasContext>(options =>
    options.UseMySql(configuration.GetConnectionString("DefaultConnection"),ServerVersion.AutoDetect(configuration.GetConnectionString("DefaultConnection"))));

var app = webAppSitio.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

//habilitamos la lectura de los archivos que están en la carpeta wwwroot del proyecto
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
