using Entities.Models;
using Repositories.Contracts;
using Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.ModelsManager
{
    public class CertificateManager : ICertificateService
    {
        private readonly IRepositoryManager _manager;

        public CertificateManager(IRepositoryManager manager)
        {
            _manager = manager;
        }
        public IEnumerable<Certificate> GetAllCertificate(bool trackChanges) => _manager.Certificate.GetAllCertificate(trackChanges);

    }
}
