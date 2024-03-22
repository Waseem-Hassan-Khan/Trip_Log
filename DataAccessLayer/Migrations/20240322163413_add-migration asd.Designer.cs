﻿// <auto-generated />
using DataAccessLayer;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DataAccessLayer.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240322163413_add-migration asd")]
    partial class addmigrationasd
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ActivitiesTripLogModel", b =>
                {
                    b.Property<int>("ActivitiesActivityId")
                        .HasColumnType("int");

                    b.Property<int>("TripsTripId")
                        .HasColumnType("int");

                    b.HasKey("ActivitiesActivityId", "TripsTripId");

                    b.HasIndex("TripsTripId");

                    b.ToTable("ActivitiesTripLogModel");
                });

            modelBuilder.Entity("DataAccessLayer.Models.Accommodation", b =>
                {
                    b.Property<int>("AccommodationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AccommodationId"));

                    b.Property<string>("AccommodationEmail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AccommodationName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AccommodationPhone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AccommodationId");

                    b.ToTable("accomodation");

                    b.HasData(
                        new
                        {
                            AccommodationId = 1,
                            AccommodationEmail = "info@hilton.com",
                            AccommodationName = "Hilton Hotel",
                            AccommodationPhone = "+123456789"
                        },
                        new
                        {
                            AccommodationId = 2,
                            AccommodationEmail = "info@marriott.com",
                            AccommodationName = "Marriott Resort",
                            AccommodationPhone = "+987654321"
                        },
                        new
                        {
                            AccommodationId = 3,
                            AccommodationEmail = "host@airbnb.com",
                            AccommodationName = "Airbnb Apartment",
                            AccommodationPhone = "+111222333"
                        },
                        new
                        {
                            AccommodationId = 4,
                            AccommodationEmail = "info@holidayinn.com",
                            AccommodationName = "Holiday Inn Express",
                            AccommodationPhone = "+444555666"
                        },
                        new
                        {
                            AccommodationId = 5,
                            AccommodationEmail = "info@sheraton.com",
                            AccommodationName = "Sheraton Suites",
                            AccommodationPhone = "+777888999"
                        },
                        new
                        {
                            AccommodationId = 6,
                            AccommodationEmail = "info@radisson.com",
                            AccommodationName = "Radisson Blu",
                            AccommodationPhone = "+555666777"
                        },
                        new
                        {
                            AccommodationId = 7,
                            AccommodationEmail = "info@hyatt.com",
                            AccommodationName = "Hyatt Regency",
                            AccommodationPhone = "+222333444"
                        },
                        new
                        {
                            AccommodationId = 8,
                            AccommodationEmail = "info@motel6.com",
                            AccommodationName = "Motel 6",
                            AccommodationPhone = "+666777888"
                        },
                        new
                        {
                            AccommodationId = 9,
                            AccommodationEmail = "info@fourseasons.com",
                            AccommodationName = "Four Seasons Resort",
                            AccommodationPhone = "+999000111"
                        },
                        new
                        {
                            AccommodationId = 10,
                            AccommodationEmail = "info@bestwestern.com",
                            AccommodationName = "Best Western Plus",
                            AccommodationPhone = "+123123123"
                        });
                });

            modelBuilder.Entity("DataAccessLayer.Models.Activities", b =>
                {
                    b.Property<int>("ActivityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ActivityId"));

                    b.Property<string>("ActivityName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ActivityId");

                    b.ToTable("activities");

                    b.HasData(
                        new
                        {
                            ActivityId = 1,
                            ActivityName = "Skiing"
                        },
                        new
                        {
                            ActivityId = 2,
                            ActivityName = "Swimming"
                        },
                        new
                        {
                            ActivityId = 3,
                            ActivityName = "Skydiving"
                        },
                        new
                        {
                            ActivityId = 4,
                            ActivityName = "Hiking"
                        },
                        new
                        {
                            ActivityId = 5,
                            ActivityName = "Surfing"
                        },
                        new
                        {
                            ActivityId = 6,
                            ActivityName = "Bungee jumping"
                        },
                        new
                        {
                            ActivityId = 7,
                            ActivityName = "Rock climbing"
                        },
                        new
                        {
                            ActivityId = 8,
                            ActivityName = "Snorkeling"
                        },
                        new
                        {
                            ActivityId = 9,
                            ActivityName = "Kayaking"
                        },
                        new
                        {
                            ActivityId = 10,
                            ActivityName = "Horseback riding"
                        });
                });

            modelBuilder.Entity("DataAccessLayer.Models.Destination", b =>
                {
                    b.Property<int>("DestinationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DestinationId"));

                    b.Property<string>("DestinationName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DestinationId");

                    b.ToTable("destination");

                    b.HasData(
                        new
                        {
                            DestinationId = 1,
                            DestinationName = "Paris"
                        },
                        new
                        {
                            DestinationId = 2,
                            DestinationName = "New York City"
                        },
                        new
                        {
                            DestinationId = 3,
                            DestinationName = "Tokyo"
                        },
                        new
                        {
                            DestinationId = 4,
                            DestinationName = "Rome"
                        },
                        new
                        {
                            DestinationId = 5,
                            DestinationName = "Sydney"
                        },
                        new
                        {
                            DestinationId = 6,
                            DestinationName = "Cape Town"
                        },
                        new
                        {
                            DestinationId = 7,
                            DestinationName = "Rio de Janeiro"
                        },
                        new
                        {
                            DestinationId = 8,
                            DestinationName = "Bali"
                        },
                        new
                        {
                            DestinationId = 9,
                            DestinationName = "Barcelona"
                        },
                        new
                        {
                            DestinationId = 10,
                            DestinationName = "Dubai"
                        });
                });

            modelBuilder.Entity("Trip_Log.Models.TripLogModel", b =>
                {
                    b.Property<int>("TripId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TripId"));

                    b.Property<int>("AccommodationId")
                        .HasColumnType("int");

                    b.Property<int>("DestinationId")
                        .HasColumnType("int");

                    b.Property<string>("EndDate")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StartDate")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ThingToDo1")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ThingToDo2")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ThingToDo3")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TripId");

                    b.HasIndex("AccommodationId");

                    b.HasIndex("DestinationId");

                    b.ToTable("tripLogModels");
                });

            modelBuilder.Entity("ActivitiesTripLogModel", b =>
                {
                    b.HasOne("DataAccessLayer.Models.Activities", null)
                        .WithMany()
                        .HasForeignKey("ActivitiesActivityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Trip_Log.Models.TripLogModel", null)
                        .WithMany()
                        .HasForeignKey("TripsTripId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Trip_Log.Models.TripLogModel", b =>
                {
                    b.HasOne("DataAccessLayer.Models.Accommodation", "AccommodationEntity")
                        .WithMany("Trips")
                        .HasForeignKey("AccommodationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DataAccessLayer.Models.Destination", "DestinationEntity")
                        .WithMany("Trips")
                        .HasForeignKey("DestinationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AccommodationEntity");

                    b.Navigation("DestinationEntity");
                });

            modelBuilder.Entity("DataAccessLayer.Models.Accommodation", b =>
                {
                    b.Navigation("Trips");
                });

            modelBuilder.Entity("DataAccessLayer.Models.Destination", b =>
                {
                    b.Navigation("Trips");
                });
#pragma warning restore 612, 618
        }
    }
}
