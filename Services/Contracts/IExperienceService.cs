﻿using Entities.Dtos;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Contracts
{
    public interface IExperienceService
    {
        void CreateExperience(Experience experience);
        void DeleteExperience(int id);
        IEnumerable<Experience> GetAllExperience(bool trackChanges);
        ExperienceUpdateDto? GetOneExperienceUpdateDto(int id, bool trackChanges);
        void UpdateExperience(ExperienceUpdateDto experienceDto);
    }
}
