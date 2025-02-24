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
        IQueryable<Experience> GetAllExperience(bool trackChanges);
    }
}
