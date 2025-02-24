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
    public class PersonalRepository : RepositoryBase<Personal>, IPersonalRepository
    {
        public PersonalRepository(ApplicationDbContext context) : base(context)
        {
        }

        public IQueryable<Personal> GetAllPersonal(bool trackChanges) => FindAll(trackChanges);
      
    }
}
