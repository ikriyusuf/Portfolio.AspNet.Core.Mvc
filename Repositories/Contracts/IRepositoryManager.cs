using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Contracts
{
   public interface IRepositoryManager
    {
        IPersonalRepository Personal { get; }
        IProjectRepository Project { get; }
        IExperienceRepository Experience { get; }
        IEducationRepository Education { get; }
        ICertificateRepository Certificate { get; }
        void Save();
    }
}
