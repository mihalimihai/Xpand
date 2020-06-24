using System.Threading.Tasks;
using XPAND.Infrastructure.Entities;

namespace XPAND.Infrastructure.Repository
{
    public class HumanRepository : Repository<Human>, IHumanRepository
    {
        private readonly XpandDbContext _context;
        public HumanRepository(XpandDbContext context) : base(context)
        {
            _context = context;
        }
        public async Task<Human> GetHumanByCrewId(int crewId)
        {
            var crew = await _context.Crews.FindAsync(crewId);
            var human = await _context.Humans.FindAsync(crew.HumanId);
            return human;
        }
    }
}
