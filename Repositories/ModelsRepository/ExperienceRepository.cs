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

        public void CreateExperience(Experience experience) => Create(experience);

        public void DeleteOneExperience(Experience experience) => Remove(experience);

        public IQueryable<Experience> GetAllExperience(bool trackChanges) => FindAll(trackChanges);

        public Experience? GetOneExperience(int id, bool trackChanges) => FindByCondition(e => e.Id.Equals(id), trackChanges);

        public void UpdateOneExperience(Experience experience) => Update(experience);
    }
}
