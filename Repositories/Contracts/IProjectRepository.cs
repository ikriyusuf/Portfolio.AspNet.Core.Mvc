using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Contracts
{
    public interface IProjectRepository : IReposityoryBase<Project>
    {
        IQueryable<Project> GetAllProject(bool trackChanges);
        Project? GetOneProject(int id, bool trackChanges);
        void CreateProject(Project project);
        void UpdateProject(Project project);
        void RemoveProject(Project project);
        void UpdateOneProject(Project project);
    }
}
