using System.Threading.Tasks;
using XPAND.Infrastructure.Entities;

namespace XPAND.Infrastructure.Repository
{
    public interface IHumanRepository : IRepository<Human>
    {
        Task<Human> GetHumanByCrewId(int crewId);
    }
}
