using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using XPAND.Infrastructure.Entities;

namespace XPAND.Infrastructure.Repository
{
    public class RobotRepository : Repository<Robot>, IRobotRepository
    {
        private readonly XpandDbContext _context;
        public RobotRepository(XpandDbContext context) : base(context)
        {
            _context = context;
        }
        public async Task<List<Robot>> GetRobotsForPlanetId(int planetId)
        {
            var planet = await _context.Plantes.FindAsync(planetId);
            var robots = from r in _context.Robots
                                 where r.CrewId == planet.CrewId
                                 select r;
            return robots.ToList();
        }
    }
}
