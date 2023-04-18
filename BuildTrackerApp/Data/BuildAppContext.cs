using BuildTrackerApp.Models;
using Microsoft.EntityFrameworkCore;

namespace BuildTrackerApp.Data
{
    public class BuildAppContext : DbContext
    {
        public BuildAppContext(DbContextOptions<BuildAppContext> options) : base(options) 
        {
        }

        public DbSet<Build> Builds { get; set; }
        public DbSet<Blocker> Blockers { get; set; }
        public DbSet<Team> Teams { get; set; }

    }
}
