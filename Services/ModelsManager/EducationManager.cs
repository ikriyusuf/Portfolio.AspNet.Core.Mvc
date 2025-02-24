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
    public class EducationManager : IEducationService
    {

        private readonly IRepositoryManager _manager;

        public EducationManager(IRepositoryManager manager)
        {
            _manager = manager;
        }
        public IEnumerable<Education> GetAllEducation(bool trackChanges) => _manager.Education.GetAllEducation(trackChanges);

    }
}
