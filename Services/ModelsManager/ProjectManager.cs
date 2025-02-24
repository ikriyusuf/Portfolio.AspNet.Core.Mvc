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
   public class ProjectManager : IProjectService
    {
        private readonly IRepositoryManager _manager;

        public ProjectManager(IRepositoryManager manager)
        {
            _manager = manager;
        }

        public IEnumerable<Project> GetAllProject(bool trackChanges) => _manager.Project.GetAllProject(trackChanges);

    }
}
