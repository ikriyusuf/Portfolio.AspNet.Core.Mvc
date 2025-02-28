using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Contracts
{
    public interface IExperienceRepository : IReposityoryBase<Experience>
    {
        void CreateExperience(Experience experience);
        void DeleteOneExperience(Experience experience);
        IQueryable<Experience> GetAllExperience(bool trackChanges);
        Experience? GetOneExperience(int id,bool trackChanges);
        void UpdateOneExperience(Experience experience);
    }
}
