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
    public class ExperienceRepository : RepositoryBase<Experience>, IExperienceRepository
    {
        public ExperienceRepository(ApplicationDbContext context) : base(context)
        {
        }

        public IQueryable<Experience> GetAllExperience(bool trackChanges) => FindAll(trackChanges);

    }
}
