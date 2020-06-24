using System.Collections.Generic;
using System.Threading.Tasks;
using XPAND.Infrastructure.Entities;

namespace XPAND.BL.Services
{
    public interface IPlanetService : IService<Planet>
    {
        Task<List<PlanetRobotsModel>> GetPlanetsAndRobotsAsync();
    }
}
