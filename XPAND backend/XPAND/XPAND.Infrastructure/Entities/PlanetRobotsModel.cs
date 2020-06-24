using System.Collections.Generic;

namespace XPAND.Infrastructure.Entities
{
    public class PlanetRobotsModel
    {
        public int PlanetId { get; set; }
        public string Name { get; set; }
        public string Status { get; set; }
        public string CaptainName { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }     
        public List<Robot> robots { get; set; }
    }
}
