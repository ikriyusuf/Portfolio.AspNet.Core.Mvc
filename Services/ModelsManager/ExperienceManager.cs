using AutoMapper;
using Entities.Dtos;
using Entities.Models;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Repositories.Contracts;
using Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.ModelsManager
{
    public class ExperienceManager : IExperienceService
    {
        private readonly IRepositoryManager _manager;
        private readonly IMapper _mapper;

        public ExperienceManager(IRepositoryManager manager,IMapper mapper)
        {
            _manager = manager;
            _mapper = mapper;
        }

        public void CreateExperience(Experience experience)
        {
            _manager.Experience.CreateExperience(experience);
            _manager.Save();
        }

        public void DeleteExperience(int id)
        {
            var entity = _manager.Experience.GetOneExperience(id,false);
            if (entity is not null)
            {
                _manager.Experience.DeleteOneExperience(entity);
                _manager.Save();
            }
        }

        public IEnumerable<Experience> GetAllExperience(bool trackChanges) => _manager.Experience.GetAllExperience(trackChanges);

        public ExperienceUpdateDto? GetOneExperienceUpdateDto(int id, bool trackChanges)
        {
            var experience = _manager.Experience.GetOneExperience(id, trackChanges);

            var experienceDto = _mapper.Map<ExperienceUpdateDto>(experience);

            return experienceDto;
        }

        public void UpdateExperience(ExperienceUpdateDto experienceDto)
        {
            var experience = _mapper.Map<Experience>(experienceDto);
            _manager.Experience.UpdateOneExperience(experience);
            _manager.Save();
        }
    }
}
