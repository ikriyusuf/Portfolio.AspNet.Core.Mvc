using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Contracts
{
   public interface IEducationRepository : IReposityoryBase<Education>
    {
        IQueryable<Education> GetAllEducation(bool trackChanges);
    }
}
