using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using XPAND.BL.Services;
using XPAND.Infrastructure.Entities;

namespace XPAND.Controllers
{
    [Route("api/planet")]
    [ApiController]
    public class PlanetController : ControllerBase
    {
        private readonly IPlanetService _planetService;
        public PlanetController(IPlanetService planetService)
        {
            _planetService = planetService;
        }

        [HttpGet]
        [Route("GetAll")]
        public async Task<IActionResult> GetPlanetsAndRobots()
        {
            List<PlanetRobotsModel> result = await _planetService.GetPlanetsAndRobotsAsync();
            return Ok(result);
        }

        [HttpPut]
        [Route("Update/{planetId}")]
        public async Task<IActionResult> UpdatePlanet([FromRoute]int planetId, [FromBody]Planet planet)
        {
            var result = await _planetService.GetById(planetId);
            result.Status = planet.Status;
            result.Description = planet.Description;
            _planetService.Update(result);
            return Ok(result);
        }
    }
}