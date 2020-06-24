using System.ComponentModel.DataAnnotations;

namespace XPAND.Infrastructure.Entities
{
    public class Planet
    {
        [Key]
        public int PlanetId { get; set; }
        public string Name { get; set; }
        public string Status { get; set; } = "En route";
        public int CrewId { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }
    }
}
