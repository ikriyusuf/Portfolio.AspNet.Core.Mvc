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

builder.Services.ConfigureDbContext(builder.Configuration); // Ioc KAYDI SQL
builder.Services.ConfigureRepository(); // IoC KAYDI REPOSİTORY
builder.Services.ConfigureService(); // IoC KAYDI SERVİCES

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
// Infrastructure.Extensions
app.MapCustomDefaultRoute();
app.MapCustomAdminRoute();
app.Run();
