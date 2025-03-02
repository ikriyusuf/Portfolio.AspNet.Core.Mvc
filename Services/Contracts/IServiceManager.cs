namespace Services.Contracts
{
    public interface IServiceManager
    {
        IPersonalService PersonalService {get;}
        IProjectService ProjectService { get; }
        IExperienceService ExperienceService { get; }
        IEducationService EducationService { get; }
        ICertificateService CertificateService { get; }
        IContactService ContactService { get; }
    }
}