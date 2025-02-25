using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure.Internal;
using Repositories;
using Repositories.Contracts;
using Repositories.Models;
using Repositories.ModelsRepository;
using Services;
using Services.Contracts;
using Services.ModelsManager;
using Portfolio.Infrastructure.Extensions;

var builder = WebApplication.CreateBuilder(args);
// Ioc KAYDI SQL
builder.Services.ConfigureDbContext(builder.Configuration);
// IoC KAYDI REPOSİTORY
builder.Services.ConfigureRepository();
// IoC KAYDI SERVİCES
builder.Services.ConfigureService();

// Add services to the container. 
builder.Services.AddControllersWithViews();

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
