using AutoMapper;
using Entities.Dtos;
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
        private readonly IMapper _mapper;


        public CertificateManager(IRepositoryManager manager,IMapper mapper)
        {
            _manager = manager;
            _mapper = mapper;
        }

        public void CreateCertificate(Certificate certificate)
        {
            _manager.Certificate.CreateCertificate(certificate);
            _manager.Save();
        }

        public void DeleteCertificate(int id)
        {
            var entity = _manager.Certificate.GetOneCertificate(id, false);
            if(entity is not null)
            {
            _manager.Certificate.DeleteCertificate(entity);
            _manager.Save();
            }
        }

        public IEnumerable<Certificate> GetAllCertificate(bool trackChanges) => _manager.Certificate.GetAllCertificate(trackChanges);

        public CertificateUpdateDto? GetOneCertificateForUpdate(int id, bool trackChanges)
        {
            var certificate = _manager.Certificate.GetOneCertificate(id, true);

            var certificateDto = _mapper.Map<CertificateUpdateDto>(certificate);

            return certificateDto;
        }

        public void UpdateCertificate(CertificateUpdateDto certificateDto)
        {
            var certificate = _mapper.Map<Certificate>(certificateDto);

            _manager.Certificate.UpdateOneCertificate(certificate);
            _manager.Save();
        }
    }
}
