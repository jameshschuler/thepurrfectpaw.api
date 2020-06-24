﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ThePurrfectPaw.API.DbContexts;

namespace ThePurrfectPaw.API.Migrations
{
    [DbContext(typeof(ThePurrfectPawContext))]
    [Migration("20200624002432_AnimalUpdate2")]
    partial class AnimalUpdate2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
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

                    b.Property<DateTime?>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.HasKey("AnimalId");

                    b.ToTable("Animals");

                    b.HasData(
                        new
                        {
                            AnimalId = 1,
                            FirstName = "Berry"
                        },
                        new
                        {
                            AnimalId = 2,
                            FirstName = "Bernard"
                        },
                        new
                        {
                            AnimalId = 3,
                            FirstName = "Peanut"
                        },
                        new
                        {
                            AnimalId = 4,
                            FirstName = "Benjamin"
                        });
                });

            modelBuilder.Entity("ThePurrfectPaw.API.Entities.Location", b =>
                {
                    b.Property<int>("LocationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasColumnType("nvarchar(13)")
                        .HasMaxLength(13);

                    b.Property<string>("StateAbbreviation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Zipcode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("LocationId");

                    b.ToTable("Locations");

                    b.HasData(
                        new
                        {
                            LocationId = 1,
                            Address = "",
                            City = "Rochester",
                            Country = "US",
                            State = "New York",
                            StateAbbreviation = "NY",
                            Zipcode = ""
                        },
                        new
                        {
                            LocationId = 2,
                            Address = "",
                            City = "Buffalo",
                            Country = "US",
                            State = "New York",
                            StateAbbreviation = "NY",
                            Zipcode = ""
                        },
                        new
                        {
                            LocationId = 3,
                            Address = "",
                            City = "Albany",
                            Country = "US",
                            State = "New York",
                            StateAbbreviation = "NY",
                            Zipcode = ""
                        },
                        new
                        {
                            LocationId = 4,
                            Address = "99 Victor Rd",
                            City = "Fairport",
                            Country = "US",
                            State = "New York",
                            StateAbbreviation = "NY",
                            Zipcode = "14450"
                        });
                });

            modelBuilder.Entity("ThePurrfectPaw.API.Entities.Posting", b =>
                {
                    b.Property<int>("PostingId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AnimalId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsPublic")
                        .HasColumnType("bit");

                    b.Property<DateTime>("PostDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("ShelterId")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(255)")
                        .HasMaxLength(255);

                    b.HasKey("PostingId");

                    b.HasIndex("AnimalId");

                    b.HasIndex("ShelterId");

                    b.ToTable("Postings");

                    b.HasData(
                        new
                        {
                            PostingId = 1,
                            AnimalId = 1,
                            IsPublic = true,
                            PostDate = new DateTime(2020, 5, 12, 5, 15, 33, 0, DateTimeKind.Unspecified),
                            ShelterId = 1,
                            Title = "Testing Posting 1"
                        },
                        new
                        {
                            PostingId = 2,
                            AnimalId = 2,
                            IsPublic = true,
                            PostDate = new DateTime(2020, 6, 5, 12, 30, 33, 0, DateTimeKind.Unspecified),
                            ShelterId = 1,
                            Title = "Testing Posting 2"
                        },
                        new
                        {
                            PostingId = 3,
                            AnimalId = 3,
                            IsPublic = false,
                            PostDate = new DateTime(2020, 6, 23, 20, 24, 31, 889, DateTimeKind.Local).AddTicks(9924),
                            ShelterId = 1,
                            Title = "Testing Posting 3"
                        },
                        new
                        {
                            PostingId = 4,
                            AnimalId = 4,
                            IsPublic = true,
                            PostDate = new DateTime(2020, 6, 20, 12, 30, 33, 0, DateTimeKind.Unspecified),
                            ShelterId = 2,
                            Title = "Testing Posting 4"
                        });
                });

            modelBuilder.Entity("ThePurrfectPaw.API.Entities.Shelter", b =>
                {
                    b.Property<int>("ShelterId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("LocationId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ShelterId");

                    b.HasIndex("LocationId");

                    b.ToTable("Shelters");

                    b.HasData(
                        new
                        {
                            ShelterId = 1,
                            Email = "",
                            LocationId = 1,
                            Name = "Verona Street Animal Society",
                            PhoneNumber = ""
                        },
                        new
                        {
                            ShelterId = 2,
                            Email = "",
                            LocationId = 4,
                            Name = "Lollypop Farm",
                            PhoneNumber = ""
                        });
                });

            modelBuilder.Entity("ThePurrfectPaw.API.Entities.Posting", b =>
                {
                    b.HasOne("ThePurrfectPaw.API.Entities.Animal", "Animal")
                        .WithMany()
                        .HasForeignKey("AnimalId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ThePurrfectPaw.API.Entities.Shelter", "Shelter")
                        .WithMany()
                        .HasForeignKey("ShelterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ThePurrfectPaw.API.Entities.Shelter", b =>
                {
                    b.HasOne("ThePurrfectPaw.API.Entities.Location", "Location")
                        .WithMany()
                        .HasForeignKey("LocationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
