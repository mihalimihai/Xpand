using XPAND.Infrastructure.Entities;
using XPAND.Infrastructure.Repository;

namespace XPAND.BL.Services
{
    public class CrewService : Service<Crew>, ICrewService
    {
        public CrewService(IRepository<Crew> crewRepository) : base(crewRepository)
        {
        }
    }
}
