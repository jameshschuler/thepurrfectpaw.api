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
        public DbSet<Posting> Posting { get; set; }
        public DbSet<Shelter> Shelters { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // seed the database with dummy data
            modelBuilder.Entity<Location>().HasData(
                new Location
                {
                    LocationId = 1,
                    City = "Rochester",
                    State = "New York"
                },
                new Location
                {
                    LocationId = 2,
                    City = "Buffalo",
                    State = "New York"
                },
                new Location
                {
                    LocationId = 3,
                    City = "Albany",
                    State = "New York"
                });
            modelBuilder.Entity<Shelter>().HasData(
                new Shelter 
                { 
                    ShelterId = 1,
                    Name = "Verona Street Animal Society",
                    LocationId = 1
                }
                );
            modelBuilder.Entity<Animal>().HasData(
                new Animal()
                {
                    AnimalId = 1,
                    FirstName = "Berry",
                    ShelterId = 1
                },
                new Animal()
                {
                    AnimalId = 2,
                    FirstName = "Bernard",
                    ShelterId = 1
                },
                new Animal()
                {
                    AnimalId = 3,
                    FirstName = "Peanut",
                    ShelterId = 1
                });

            base.OnModelCreating(modelBuilder);
        }
    }
}
