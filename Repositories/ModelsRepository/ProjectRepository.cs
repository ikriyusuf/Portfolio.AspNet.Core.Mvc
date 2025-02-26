using Entities.Models;
using Repositories.Contracts;
using Repositories.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.ModelsRepository
{
    public class ProjectRepository : RepositoryBase<Project> , IProjectRepository
    {
        public ProjectRepository(ApplicationDbContext context) : base(context)
        {
        }

        public void CreateProject(Project project) => Create(project);

        public void RemoveProject(Project project) => Remove(project);

        public IQueryable<Project> GetAllProject(bool trackChanges) => FindAll(trackChanges);

        public Project? GetOneProject(int id, bool trackChanges) => FindByCondition(p => p.Id.Equals(id), trackChanges);

        public void UpdateProject(Project project) => Update(project);

        public void UpdateOneProject(Project project) => Update(project);

    }
}
