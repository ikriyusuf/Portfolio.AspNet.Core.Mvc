using Entities.Models;
using Repositories.Contracts;
using Services.Contracts;

namespace Services.ModelsManager
{
    public class PersonalManager : IPersonalService
    {

        private readonly IRepositoryManager _manager;

        public PersonalManager(IRepositoryManager manager)
        {
            _manager = manager;
        }
        public IEnumerable<Personal> GetAllPersonal(bool trackChanges) => _manager.Personal.GetAllPersonal(trackChanges);
    }
}