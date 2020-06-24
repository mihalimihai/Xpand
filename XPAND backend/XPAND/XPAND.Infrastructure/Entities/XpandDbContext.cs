using Microsoft.EntityFrameworkCore;

namespace XPAND.Infrastructure.Entities
{
    public class XpandDbContext : DbContext
    {
        public XpandDbContext(DbContextOptions<XpandDbContext> options)
            : base(options)
        {
        }

        public DbSet<Human> Humans { get; set; }
        public DbSet<Robot> Robots { get; set; }
        public DbSet<Crew> Crews { get; set; }
        public DbSet<Planet> Plantes { get; set; }

        protected override void OnModelCreating(ModelBuilder dbModelBuilder)
        {
            dbModelBuilder.Entity<Crew>()
            .HasMany(u => u.Robots)
            .WithOne(r => r.Crew)
            .HasForeignKey(r => r.CrewId);    
        }
    }
}
