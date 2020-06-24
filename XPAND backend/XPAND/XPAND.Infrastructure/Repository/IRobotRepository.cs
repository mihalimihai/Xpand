using System.Collections.Generic;
using System.Threading.Tasks;
using XPAND.Infrastructure.Entities;

namespace XPAND.Infrastructure.Repository
{
    public interface IRobotRepository : IRepository<Robot>
    {
        Task<List<Robot>> GetRobotsForPlanetId(int planetId);
    }
}
