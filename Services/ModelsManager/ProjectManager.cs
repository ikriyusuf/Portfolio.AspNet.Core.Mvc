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
    public class ProjectManager : IProjectService
    {
        private readonly IRepositoryManager _manager;
        private readonly IMapper _mapper;

        public ProjectManager(IRepositoryManager manager,IMapper mapper)
        {
            _manager = manager;
            _mapper = mapper;
        }

        public void CreateProject(Project project)
        {
            _manager.Project.CreateProject(project);
            _manager.Save();
        }

        public IEnumerable<Project> GetAllProject(bool trackChanges) => _manager.Project.GetAllProject(trackChanges);

        public Project? GetOneProject(int id, bool trackChanges)
        {
            var project = _manager.Project.GetOneProject(id, trackChanges);
            if (project is null)
            {
                throw new Exception("Project is not found!!");
            }
            return project;
        }

        public ProjectUpdateDto? GetOneProjectForUpdate(int id, bool trackChanges)
        {
            // VERİ GÜVENLİĞİ İÇİN
            // GetOneProject'ten gelen project nesnesini alıyoruz
            var project = _manager.Project.GetOneProject(id, trackChanges);
            // project DTO'ya projectUpdateDto dönüştürüyoruz
            var projectUpdateDto = _mapper.Map<ProjectUpdateDto>(project);
            return projectUpdateDto;
        }

        public void RemoveProject(int id)
        {
            var entity = _manager.Project.GetOneProject(id, false);
            if (entity is not null)
            {
                _manager.Project.RemoveProject(entity);
                _manager.Save();
            }
        }

        public void UpdateProject(ProjectUpdateDto projectUpdateDto)
        {
            // Eski yöntem el ile güncelleme işlemi
            //var entity = _manager.Project.GetOneProject(projectUpdateDto.Id, true);
            //if (entity is not null)
            //{
            //    entity.Title = project.Title;
            //    entity.Description = project.Description;
            //    entity.Technologies = project.Technologies;
            //    _manager.Save();
            //}
            //else
            //{
            //    throw new Exception("Project to update is not found!!");
            //}

            // DTO'dan gelen veriyi doğrudan Project entity'sine dönüştürüyoruz.
            var entity = _mapper.Map<Project>(projectUpdateDto);

            // Dönüştürülen Project entity'si ile güncellenmiş veriyi veritabanına gönderiyoruz.
            _manager.Project.UpdateOneProject(entity);
            _manager.Save();
        }
    }
}
