using Repositories.Contracts;
using Repositories.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class RepositoryManager : IRepositoryManager
    {
        private readonly ApplicationDbContext _context;
        private readonly IPersonalRepository _personalRepository;
        private readonly IProjectRepository _projectRepository;
        private readonly IExperienceRepository _experienceRepository;
        private readonly IEducationRepository _educationRepository;
        private readonly ICertificateRepository _certificateRepository;
        private readonly IContactRepository _contactRepository;
        public RepositoryManager(IPersonalRepository personalRepository, ApplicationDbContext context, 
            IProjectRepository projectRepository, IExperienceRepository experienceRepository,
            IEducationRepository educationRepository, ICertificateRepository certificateRepository,
            IContactRepository contactRepository)
        {
            _experienceRepository = experienceRepository;
            _personalRepository = personalRepository;
            _projectRepository = projectRepository;
            _context = context;
            _educationRepository = educationRepository;
            _certificateRepository = certificateRepository;
            _contactRepository = contactRepository;
        }

        public IPersonalRepository Personal => _personalRepository;
        public IProjectRepository Project => _projectRepository;
        public IExperienceRepository Experience => _experienceRepository;
        public IEducationRepository Education => _educationRepository;
        public ICertificateRepository Certificate => _certificateRepository;
        public IContactRepository Contact => _contactRepository;

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
