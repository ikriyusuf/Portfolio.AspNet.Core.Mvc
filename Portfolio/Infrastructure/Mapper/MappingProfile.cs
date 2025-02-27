using AutoMapper;
using Entities.Dtos;
using Entities.Models;

namespace Portfolio.Infrastructure.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<ProjectUpdateDto, Project>().ReverseMap();
            CreateMap<CertificateUpdateDto, Certificate>().ReverseMap();
        }
    }
}
