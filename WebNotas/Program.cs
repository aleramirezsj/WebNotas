using Microsoft.EntityFrameworkCore;
using WebNotas.Models;

var builder = WebApplication.CreateBuilder(args);

var Configuration = new ConfigurationBuilder()
        .AddJsonFile("appsettings.json")
        .Build();
// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<WebNotasContext>(options =>
    options.UseMySql(Configuration.GetConnectionString("DefaultConnection"),ServerVersion.AutoDetect(Configuration.GetConnectionString("DefaultConnection"))));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
