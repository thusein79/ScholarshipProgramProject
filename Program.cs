using Microsoft.EntityFrameworkCore;
using ScholarshipProgramProject.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

// DI for DBContext
builder.Services.AddDbContext<StudentsDBContext>(DbOptions=>DbOptions.UseSqlServer(builder.Configuration.GetConnectionString("SCDBConnection")));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
