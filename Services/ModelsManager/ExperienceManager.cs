using Entities.Models;
using Repositories.Contracts;
using Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.ModelsManager
{
    public class ExperienceManager : IExperienceService
    {
        private readonly IRepositoryManager _manager;

        public ExperienceManager(IRepositoryManager manager)
        {
            _manager = manager;
        }

        public IEnumerable<Experience> GetAllExperience(bool trackChanges) => _manager.Experience.GetAllExperience(trackChanges); 
    }
}
