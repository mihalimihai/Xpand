using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace XPAND.Infrastructure.Entities
{
    public partial class Crew
    {
        [Key]
        public int CrewId { get; set; }
        [ForeignKey("Human")]
        public int HumanId { get; set; }
        public virtual Human Human { get; set; }
        public virtual ICollection<Robot> Robots { get; set; }
    }
}
