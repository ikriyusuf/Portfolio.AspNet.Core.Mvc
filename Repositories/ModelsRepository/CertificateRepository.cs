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
    public class CertificateRepository : RepositoryBase<Certificate>, ICertificateRepository
    {
        public CertificateRepository(ApplicationDbContext context) : base(context)
        {
        }

        public IQueryable<Certificate> GetAllCertificate(bool trackChanges) => FindAll(trackChanges);
    }
}
