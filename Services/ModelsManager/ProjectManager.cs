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

        public void CreateProject(Project project)
        {
            _manager.Project.CreateProject(project);
            _manager.Save();
        }

        public IEnumerable<Project> GetAllProject(bool trackChanges) => _manager.Project.GetAllProject(trackChanges);

        public Project? GetOneProject(int id, bool trackChanges)
        {
            var project = _manager.Project.GetOneProject(id, trackChanges);
            if (project is null)
            {
                throw new Exception("Project is not found!!");
            }
            return project;
        }

        public void UpdateProject(Project project)
        {
            var entity = _manager.Project.GetOneProject(project.Id, true);
            entity.Title = project.Title;
            entity.Description = project.Description;
            entity.Technologies = project.Technologies;
            _manager.Save();
        }
    }
}
