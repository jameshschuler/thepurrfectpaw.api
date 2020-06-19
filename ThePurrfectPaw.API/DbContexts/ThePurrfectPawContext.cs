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

        //public DbSet<Animal> Animals { get; set; }
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
                    LocationId = 1,
                    City = "Rochester",
                    State = "New York",
                    StateAbbreviation = "NY",
                    Country = "US",
                    Zipcode = ""
                },
                new Location
                {
                    LocationId = 2,
                    City = "Buffalo",
                    State = "New York",
                    StateAbbreviation = "NY",
                    Country = "US",
                    Zipcode = ""
                },
                new Location
                {
                    LocationId = 3,
                    City = "Albany",
                    State = "New York",
                    StateAbbreviation = "NY",
                    Country = "US",
                    Zipcode = ""
                } );

            /*
             * Shelters
             */
            modelBuilder.Entity<Shelter>().HasData(
                new Shelter
                {
                    ShelterId = 1,
                    Name = "Verona Street Animal Society",
                    LocationId = 1
                } );

            /*
             * Animals
             */
            //modelBuilder.Entity<Animal>().HasData(
            //    new Animal()
            //    {
            //        AnimalId = 1,
            //        FirstName = "Berry",
            //    },
            //    new Animal()
            //    {
            //        AnimalId = 2,
            //        FirstName = "Bernard",
            //    },
            //    new Animal()
            //    {
            //        AnimalId = 3,
            //        FirstName = "Peanut",
            //    });

            /*
             * Postings
             */
            modelBuilder.Entity<Posting>().HasData(
                new Posting 
                { 
                    PostingId = 1,
                    Title = "Testing Posting 1",
                    PostDate = new DateTime(2020, 05, 12, 5, 15, 33),
                    IsPublic = true,
                    ShelterId = 1
                },
                new Posting
                {
                    PostingId = 2,
                    Title = "Testing Posting 2",
                    PostDate = new DateTime( 2020, 06, 5, 12, 30, 33 ),
                    IsPublic = true,
                    ShelterId = 1
                },
                new Posting
                {
                    PostingId = 3,
                    Title = "Testing Posting 3",
                    PostDate = DateTime.Now,
                    IsPublic = false,
                    ShelterId = 1
                } );

            base.OnModelCreating(modelBuilder);
        }
    }
}
