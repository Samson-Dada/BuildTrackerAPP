using BuildTrackerApp.Models;
using Microsoft.EntityFrameworkCore;

namespace BuildTrackerApp.Data
{
    public class BuildAppContext : DbContext
    {
        public BuildAppContext(DbContextOptions<BuildAppContext> options) : base(options) 
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var build = new List<Build>()
            {
                new Build()
                {
                    Id= 1,
                    Title ="Add new method",
                    ShortDescription="New post method",
                    Description ="new post request that send data to the list of build",
                    Role = Role.Backend,
                    OpenTask = 5,
                    CloseTask= 6,
                    CreatedTime = DateTime.Now,

                },
                 new Build()
                {
                    Id= 2,
                    Title ="new UI",
                    ShortDescription="New UI for customer",
                    Description ="new UI for customer to view number of sales ",
                    Role = Role.UIUX,
                    OpenTask = 6,
                    CloseTask= 2,
                    CreatedTime = DateTime.Now,
                }
                
            };


            var blocker = new List<Blocker>()
            {
                new Blocker
                {
                    Id= 1,
                    Title = "Error code",   
                    ShortDescription ="Packege not supported",
                    Description= "Unable to found package you are using",
                    Role = Role.Backend,
                    Priority = BlockerPriority.Medium,
                    BlockerStatus = BlockerStatus.Bug,
                    CreatedTime = DateTime.Now,
                },
                  new Blocker
                {
                    Id= 2,
                    Title = "Test",
                    ShortDescription ="Testing fail",
                    Description= "Testing fail due to logical error that the function return",
                    Role = Role.Backend,
                    Priority = BlockerPriority.Medium,
                    BlockerStatus = BlockerStatus.Testing,
                    CreatedTime = DateTime.Now,
                   }
            };

            var email = "@harmonica.com";
            var teams = new List<Team>()
            {
                new Team
                {
                    Id = 1,
                    FirstName= "John",
                    LastName= "Deo",
                    Email= $"johnd{email}",
                    ProductRole ="Team Lead",
                    Role = "Product Manager",
                    Status = true,
                    Task = "Scrum Master",
                    ImageUrl = ""
                    
                },
                 new Team
                {
                    Id = 2,
                    FirstName= "Pablo",
                    LastName= "Seun",
                    Email= $"pablos{email}",
                    ProductRole ="Agile Team",
                    Role = "Backend Engineer",
                    Status = true,
                    Task = "Web APIs",
                    ImageUrl = ""

                },
                  new Team()
                {
                    Id = 3,
                    FirstName= "Cayote",
                    LastName= "Bola",
                    Email= $"cayoteb{email}",
                    ProductRole ="Agile Team",
                    Role = "Product Desginer",
                    Status = false,
                    Task = "Design UI & UX",
                    ImageUrl = ""

                }
            };
            modelBuilder.Entity<Build>().HasData(build);
            modelBuilder.Entity<Team>().HasData(teams);
            modelBuilder.Entity<Blocker>().HasData(blocker);
        }
        public DbSet<Build> Builds { get; set; }
        public DbSet<Blocker> Blockers { get; set; }
        public DbSet<Team> Teams { get; set; }

    }
}
