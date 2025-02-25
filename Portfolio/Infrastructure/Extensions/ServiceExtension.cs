using Microsoft.EntityFrameworkCore;
using Repositories.Contracts;
using Repositories;
using Repositories.Models;
using Repositories.ModelsRepository;
using Services.Contracts;
using Services.ModelsManager;
using Services;

namespace Portfolio.Infrastructure.Extensions
{
    public static class ServiceExtension
    {
        public static void ConfigureDbContext(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
                    options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"),
                    options => options.MigrationsAssembly("Portfolio"))
);
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
    }
}
