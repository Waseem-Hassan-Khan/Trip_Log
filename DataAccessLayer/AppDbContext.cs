using DataAccessLayer.Models;
using Microsoft.EntityFrameworkCore;
using Trip_Log.Models;

namespace DataAccessLayer
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Accommodation> accomodation { get; set; }
        public DbSet<TripLogModel> tripLogModels { get; set; }
        public DbSet<Destination> destination { get; set; }
        public DbSet<Activities> activities { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Activities>().HasData(
                new Activities { ActivityId=1, ActivityName = "Skiing" },
                new Activities { ActivityId = 2, ActivityName = "Swimming" },
                new Activities { ActivityId = 3, ActivityName = "Skydiving" },
                new Activities { ActivityId = 4, ActivityName = "Hiking" },
                new Activities { ActivityId = 5, ActivityName = "Surfing" },
                new Activities { ActivityId = 6, ActivityName = "Bungee jumping" },
                new Activities { ActivityId = 7, ActivityName = "Rock climbing" },
                new Activities { ActivityId = 8, ActivityName = "Snorkeling" },
                new Activities { ActivityId = 9, ActivityName = "Kayaking" },
                new Activities { ActivityId = 10, ActivityName = "Horseback riding" }
                );

            modelBuilder.Entity<Destination>().HasData(
                new Destination { DestinationId=1, DestinationName = "Paris" },
                new Destination { DestinationId = 2, DestinationName = "New York City" },
                new Destination { DestinationId = 3, DestinationName = "Tokyo" },
                new Destination { DestinationId = 4, DestinationName = "Rome" },
                new Destination { DestinationId = 5, DestinationName = "Sydney" },
                new Destination { DestinationId = 6, DestinationName = "Cape Town" },
                new Destination { DestinationId = 7, DestinationName = "Rio de Janeiro" },
                new Destination { DestinationId = 8, DestinationName = "Bali" },
                new Destination { DestinationId = 9, DestinationName = "Barcelona" },
                new Destination { DestinationId = 10, DestinationName = "Dubai" }
                 );



            modelBuilder.Entity<Accommodation>().HasData(
                new Accommodation {
                    AccommodationId = 1,
                    AccommodationName = "Hilton Hotel",
                    AccommodationPhone = "+123456789", AccommodationEmail = "info@hilton.com" },

                new Accommodation {
                    AccommodationId = 2,
                    AccommodationName = "Marriott Resort", 
                    AccommodationPhone = "+987654321", AccommodationEmail = "info@marriott.com" },

                new Accommodation {
                    AccommodationId = 3,
                    AccommodationName = "Airbnb Apartment", 
                    AccommodationPhone = "+111222333", AccommodationEmail = "host@airbnb.com" },

                new Accommodation {
                    AccommodationId = 4,
                    AccommodationName = "Holiday Inn Express", 
                    AccommodationPhone = "+444555666", AccommodationEmail = "info@holidayinn.com" },

                new Accommodation {
                    AccommodationId = 5,
                    AccommodationName = "Sheraton Suites", 
                    AccommodationPhone = "+777888999", AccommodationEmail = "info@sheraton.com" },

                new Accommodation {
                    AccommodationId = 6,
                    AccommodationName = "Radisson Blu", 
                    AccommodationPhone = "+555666777", AccommodationEmail = "info@radisson.com" },

                new Accommodation {
                    AccommodationId = 7,
                    AccommodationName = "Hyatt Regency", 
                    AccommodationPhone = "+222333444", AccommodationEmail = "info@hyatt.com" },

                new Accommodation {
                    AccommodationId = 8,
                    AccommodationName = "Motel 6", 
                    AccommodationPhone = "+666777888", AccommodationEmail = "info@motel6.com" },

                new Accommodation {
                    AccommodationId = 9,
                    AccommodationName = "Four Seasons Resort", 
                    AccommodationPhone = "+999000111", AccommodationEmail = "info@fourseasons.com" },

                new Accommodation {
                    AccommodationId = 10,
                    AccommodationName = "Best Western Plus", 
                    AccommodationPhone = "+123123123", AccommodationEmail = "info@bestwestern.com" }
                );
        }
    }
}
