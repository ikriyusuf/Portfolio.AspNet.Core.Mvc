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
   public class EducationRepository : RepositoryBase<Education>, IEducationRepository
    {
        public EducationRepository(ApplicationDbContext context) : base(context)
        {
        }

        public IQueryable<Education> GetAllEducation(bool trackChanges) => FindAll(trackChanges);

    }
}
