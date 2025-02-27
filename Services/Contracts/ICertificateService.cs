using Entities.Dtos;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Contracts
{
    public interface ICertificateService 
    {
        void CreateCertificate(Certificate certificate);
        void DeleteCertificate(int id);
        IEnumerable<Certificate> GetAllCertificate(bool trackChanges);
        CertificateUpdateDto? GetOneCertificateForUpdate(int id, bool trackChanges);
        void UpdateCertificate(CertificateUpdateDto certificateDto);
    }
}
