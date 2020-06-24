using Microsoft.EntityFrameworkCore;
using System;
using ThePurrfectPaw.API.Entities;

namespace ThePurrfectPaw.API.DbContexts
{
    public class ThePurrfectPawContext : DbContext
    {
        public ThePurrfectPawContext(DbContextOptions<ThePurrfectPawContext> options)
           : base(options)
        {
        }

        public DbSet<Animal> Animals { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<Posting> Postings { get; set; }
        public DbSet<Shelter> Shelters { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // seed the database with dummy data

            /*
             * Locations
             */
            modelBuilder.Entity<Location>().HasData(
                new Location
                {
                    Address = "",
                    LocationId = 1,
                    City = "Rochester",
                    State = "New York",
                    StateAbbreviation = "NY",
                    Country = "US",
                    Zipcode = ""
                },
                new Location
                {
                    Address = "",
                    LocationId = 2,
                    City = "Buffalo",
                    State = "New York",
                    StateAbbreviation = "NY",
                    Country = "US",
                    Zipcode = ""
                },
                new Location
                {
                    Address = "",
                    LocationId = 3,
                    City = "Albany",
                    State = "New York",
                    StateAbbreviation = "NY",
                    Country = "US",
                    Zipcode = ""
                },
                new Location
                {
                    Address = "99 Victor Rd",
                    LocationId = 4,
                    City = "Fairport",
                    State = "New York",
                    StateAbbreviation = "NY",
                    Country = "US",
                    Zipcode = "14450"
                } );

            /*
             * Shelters
             */
            modelBuilder.Entity<Shelter>().HasData(
                new Shelter
                {
                    Email = "",
                    PhoneNumber = "",
                    ShelterId = 1,
                    Name = "Verona Street Animal Society",
                    LocationId = 1
                },
                new Shelter
                {
                    Email = "",
                    PhoneNumber = "",
                    ShelterId = 2,
                    Name = "Lollypop Farm",
                    LocationId = 4
                } );

            /*
             * Animals
             */
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
                },
                new Animal()
                {
                    AnimalId = 4,
                    FirstName = "Benjamin",
                } );

            /*
             * Postings
             */
            modelBuilder.Entity<Posting>().HasData(
                new Posting 
                { 
                    AnimalId = 1,
                    PostingId = 1,
                    Title = "Testing Posting 1",
                    PostDate = new DateTime(2020, 05, 12, 5, 15, 33),
                    IsPublic = true,
                    ShelterId = 1,
                },
                new Posting
                {
                    AnimalId = 2,
                    PostingId = 2,
                    Title = "Testing Posting 2",
                    PostDate = new DateTime( 2020, 06, 5, 12, 30, 33 ),
                    IsPublic = true,
                    ShelterId = 1,
                },
                new Posting
                {
                    AnimalId = 3,
                    PostingId = 3,
                    Title = "Testing Posting 3",
                    PostDate = DateTime.Now,
                    IsPublic = false,
                    ShelterId = 1,
                },
                new Posting
                {
                    AnimalId = 4,
                    PostingId = 4,
                    Title = "Test Run 123",
                    PostDate = new DateTime( 2020, 06, 20, 12, 30, 33 ),
                    IsPublic = true,
                    ShelterId = 2,
                } );

            base.OnModelCreating(modelBuilder);
        }
    }
}
