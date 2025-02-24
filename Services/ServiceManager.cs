using Services.Contracts;

namespace Services
{
    public class ServiceManager : IServiceManager
    {
        private readonly IPersonalService _personalService;
        private readonly IProjectService _projectService;
        private readonly IExperienceService _experienceService;
        private readonly IEducationService _educationService;
        private readonly ICertificateService _certificateService;

        public ServiceManager(IPersonalService personalService, IProjectService projectService, 
            IExperienceService experienceService, IEducationService educationService, ICertificateService certificateService)
        {
            _personalService = personalService;
            _projectService = projectService;
            _experienceService = experienceService;
            _educationService = educationService;
            _certificateService = certificateService;
        }
        public IPersonalService PersonalService => _personalService;
        public IProjectService ProjectService => _projectService;
        public IExperienceService ExperienceService => _experienceService;
        public IEducationService EducationService => _educationService;
        public ICertificateService CertificateService => _certificateService;
    }
}