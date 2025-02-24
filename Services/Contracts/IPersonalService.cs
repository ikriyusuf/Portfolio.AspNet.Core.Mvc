using Entities.Models;

namespace Services.Contracts
{
    public interface IPersonalService
    {
        IEnumerable<Personal> GetAllPersonal(bool trackChanges);
    }

}