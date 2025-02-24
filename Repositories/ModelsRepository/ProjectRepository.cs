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

        public IQueryable<Project> GetAllProject(bool trackChanges) => FindAll(trackChanges);

    }
}
