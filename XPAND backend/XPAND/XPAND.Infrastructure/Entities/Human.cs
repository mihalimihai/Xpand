using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace XPAND.Infrastructure.Entities
{
    public class Human
    {
        [Key]
        public int HumanId { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public virtual Crew Crew { get; set; }
    }
}
