using System.Collections.Generic;
using System.Threading.Tasks;
using XPAND.Infrastructure.Entities;
using XPAND.Infrastructure.Repository;

namespace XPAND.BL.Services
{
    public class PlanetService : Service<Planet>, IPlanetService
    {
        private readonly IRobotRepository _robotRepository;
        private readonly IHumanRepository _humanRepository;
        public PlanetService(IHumanRepository humanRepository, IRobotRepository robotRepository, IRepository<Planet> planetRepository) : base(planetRepository)
        {
            _robotRepository = robotRepository;
            _humanRepository = humanRepository;
        }

        public async Task<List<PlanetRobotsModel>> GetPlanetsAndRobotsAsync()
        {
            List<PlanetRobotsModel> result = new List<PlanetRobotsModel>();
            List<Planet> planets = await GetAll();
            foreach (var planet in planets)
            {
                var robots = await _robotRepository.GetRobotsForPlanetId(planet.PlanetId);
                //var captain = await _humanRepository.GetHumanByCrewId(planet.CrewId);

                var model = new PlanetRobotsModel();
                model.robots = robots;
                model.PlanetId = planet.PlanetId;
                model.Name = planet.Name;
                //model.CaptainName = captain.Name;
                model.Status = planet.Status;
                model.Image = planet.Image;
                model.Description = planet.Description;
                result.Add(model);
            }
            return result;
        }
    }
}
