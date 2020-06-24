using System.Threading.Tasks;
using XPAND.Infrastructure.Entities;
using XPAND.Infrastructure.Repository;

namespace XPAND.BL.Services
{
    public class HumanService : Service<Human>, IHumanService
    {       
        public HumanService( ICrewRepository crewRepository, IRepository<Human> humanRepository) : base(humanRepository)
        {          
        }
    }
}
