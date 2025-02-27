using Microsoft.EntityFrameworkCore;
using Repositories.Contracts;
using Repositories;
using Repositories.Models;
using Repositories.ModelsRepository;
using Services.Contracts;
using Services.ModelsManager;
using Services;
using Microsoft.AspNetCore.Identity;

namespace Portfolio.Infrastructure.Extensions
{
    public static class ServiceExtension
    {
        public static void ConfigureDbContext(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"),
                    b => b.MigrationsAssembly("Portfolio"));
                // Hassas bilgileri loglara yansıtmak için
                options.EnableSensitiveDataLogging(true);
            });
        }
        public static void ConfigureIdentity(this IServiceCollection services)
        {
            services.AddIdentity<IdentityUser, IdentityRole>(options =>
            {
                options.SignIn.RequireConfirmedAccount = false;
                options.User.RequireUniqueEmail = true;
                options.Password.RequireUppercase = false;
                options.Password.RequireLowercase = false;
                options.Password.RequireDigit = false;
                options.Password.RequiredLength = 6;
            }).AddEntityFrameworkStores<ApplicationDbContext>();
        }

        public static void ConfigureRepository(this IServiceCollection services)
        {
            services.AddScoped<IRepositoryManager, RepositoryManager>();
            services.AddScoped<IPersonalRepository, PersonalRepository>();
            services.AddScoped<IProjectRepository, ProjectRepository>();
            services.AddScoped<IExperienceRepository, ExperienceRepository>();
            services.AddScoped<IEducationRepository, EducationRepository>();
            services.AddScoped<ICertificateRepository, CertificateRepository>();
        }

        public static void ConfigureService(this IServiceCollection services)
        {
            services.AddScoped<IServiceManager, ServiceManager>();
            services.AddScoped<IPersonalService, PersonalManager>();
            services.AddScoped<IProjectService, ProjectManager>();
            services.AddScoped<IExperienceService, ExperienceManager>();
            services.AddScoped<IEducationService, EducationManager>();
            services.AddScoped<ICertificateService, CertificateManager>();
        }

        public static void ConfigureRouting(this IServiceCollection services)
        {
            services.AddRouting(options =>
            {
                // Url ifadelerinin küçük harf ile gösterilmesini sağlamak.
                options.LowercaseUrls = true;
                options.AppendTrailingSlash = false;
            });
        }
    }
}
