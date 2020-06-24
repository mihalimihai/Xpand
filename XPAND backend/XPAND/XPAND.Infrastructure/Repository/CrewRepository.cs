using System;
using System.Collections.Generic;
using System.Text;
using XPAND.Infrastructure.Entities;

namespace XPAND.Infrastructure.Repository
{
    public class CrewRepository : Repository<Crew>, ICrewRepository
    {       
        public CrewRepository(XpandDbContext context) : base(context)
        {           
        }
    }
}
