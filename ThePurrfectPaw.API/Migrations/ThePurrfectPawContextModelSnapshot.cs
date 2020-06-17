﻿// <auto-generated />
using CourseLibrary.API.DbContexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ThePurrfectPaw.API.Migrations
{
    [DbContext(typeof(ThePurrfectPawContext))]
    partial class ThePurrfectPawContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ThePurrfectPaw.API.Entities.Animal", b =>
                {
                    b.Property<int>("AnimalId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<int>("LocationId")
                        .HasColumnType("int");

                    b.HasKey("AnimalId");

                    b.HasIndex("LocationId");

                    b.ToTable("Animals");

                    b.HasData(
                        new
                        {
                            AnimalId = 1,
                            FirstName = "Berry",
                            LocationId = 1
                        },
                        new
                        {
                            AnimalId = 2,
                            FirstName = "Bernard",
                            LocationId = 1
                        },
                        new
                        {
                            AnimalId = 3,
                            FirstName = "Peanut",
                            LocationId = 3
                        });
                });

            modelBuilder.Entity("ThePurrfectPaw.API.Entities.Location", b =>
                {
                    b.Property<int>("LocationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasColumnType("nvarchar(13)")
                        .HasMaxLength(13);

                    b.HasKey("LocationId");

                    b.ToTable("Locations");

                    b.HasData(
                        new
                        {
                            LocationId = 1,
                            City = "Rochester",
                            State = "New York"
                        },
                        new
                        {
                            LocationId = 2,
                            City = "Buffalo",
                            State = "New York"
                        },
                        new
                        {
                            LocationId = 3,
                            City = "Albany",
                            State = "New York"
                        });
                });

            modelBuilder.Entity("ThePurrfectPaw.API.Entities.Animal", b =>
                {
                    b.HasOne("ThePurrfectPaw.API.Entities.Location", "Location")
                        .WithMany("Animals")
                        .HasForeignKey("LocationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
