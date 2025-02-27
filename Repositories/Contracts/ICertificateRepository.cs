using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Contracts
{
   public interface ICertificateRepository : IReposityoryBase<Certificate>
    {
        void CreateCertificate(Certificate certificate);
        void DeleteCertificate(Certificate certificate);
        IQueryable<Certificate> GetAllCertificate(bool trackChanges);
        Certificate? GetOneCertificate(int id, bool trackChanges);
        void UpdateOneCertificate(Certificate certificate);
    }
}
