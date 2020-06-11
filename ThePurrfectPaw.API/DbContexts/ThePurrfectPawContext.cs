using Microsoft.EntityFrameworkCore;
using ThePurrfectPaw.API.Entities;

namespace CourseLibrary.API.DbContexts
{
    public class ThePurrfectPawContext : DbContext
    {
        public ThePurrfectPawContext(DbContextOptions<ThePurrfectPawContext> options)
           : base(options)
        {
        }

        public DbSet<Animal> Animals { get; set; }
        public DbSet<Location> Locations { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // seed the database with dummy data
            modelBuilder.Entity<Animal>().HasData(
                new Animal()
                {
                    AnimalId = 1,
                    FirstName = "Berry",
                },
                new Animal()
                {
                    AnimalId = 2,
                    FirstName = "Bernard",
                },
                new Animal()
                {
                    AnimalId = 3,
                    FirstName = "Peanut",
                });

            modelBuilder.Entity<Location>().HasData(
                new Location
                {
                    LocationId = 1,
                    City = "Rochester",
                    State = "New York"
                },
                new Location
                {
                    LocationId = 1,
                    City = "Buffalo",
                    State = "New York"
                },
                new Location
                {
                    LocationId = 1,
                    City = "Albany",
                    State = "New York"
                });

            base.OnModelCreating(modelBuilder);
        }
    }
}
