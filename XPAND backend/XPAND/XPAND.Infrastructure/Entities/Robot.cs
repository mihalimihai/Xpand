using System.ComponentModel.DataAnnotations;

namespace XPAND.Infrastructure.Entities
{
    public class Robot
    {
        [Key]
        public int RobotId { get; set; }
        public string Name { get; set; }
        public int CrewId { get; set; }
        public virtual Crew Crew { get; set; }
    }
}
