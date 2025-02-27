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
        public void CreateCertificate(Certificate certificate) => Create(certificate);

        public void DeleteCertificate(Certificate certificate) => Remove(certificate);

        public IQueryable<Certificate> GetAllCertificate(bool trackChanges) => FindAll(trackChanges);

        public Certificate? GetOneCertificate(int id, bool trackChanges) => FindByCondition(c => c.Id.Equals(id),trackChanges);

        public void UpdateOneCertificate(Certificate certificate) => Update(certificate);
    }
}
