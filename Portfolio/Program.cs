using Microsoft.EntityFrameworkCore;
using Repositories;
using Repositories.Contracts;
using Repositories.Models;
using Repositories.ModelsRepository;
using Services;
using Services.Contracts;
using Services.ModelsManager;

var builder = WebApplication.CreateBuilder(args);
// SQL BA�LANTISI
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"),
    options => options.MigrationsAssembly("Portfolio"))
);

// IoC KAYDI GER�EKLE�T�R�YORUZ. REPOSİTORY
builder.Services.AddScoped<IRepositoryManager, RepositoryManager>();
builder.Services.AddScoped<IPersonalRepository, PersonalRepository>();
builder.Services.AddScoped<IProjectRepository, ProjectRepository>();
builder.Services.AddScoped<IExperienceRepository, ExperienceRepository>();
builder.Services.AddScoped<IEducationRepository, EducationRepository>();
builder.Services.AddScoped<ICertificateRepository, CertificateRepository>();

// IoC KAYDI GER�EKLE�T�R�YORUZ. SERVİCES
builder.Services.AddScoped<IServiceManager, ServiceManager>();
builder.Services.AddScoped<IPersonalService, PersonalManager>();
builder.Services.AddScoped<IProjectService, ProjectManager>();
builder.Services.AddScoped<IExperienceService, ExperienceManager>();
builder.Services.AddScoped<IEducationService, EducationManager>();
builder.Services.AddScoped<ICertificateService, CertificateManager>();

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
