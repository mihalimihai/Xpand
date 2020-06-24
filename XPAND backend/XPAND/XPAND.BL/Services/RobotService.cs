using System.Collections.Generic;
using System.Threading.Tasks;
using XPAND.Infrastructure.Entities;
using XPAND.Infrastructure.Repository;

namespace XPAND.BL.Services
{
    public class RobotService : Service<Robot>, IRobotService
    {
        public RobotService(IRobotRepository robotRepository) : base(robotRepository)
        {
        }
    }
}
