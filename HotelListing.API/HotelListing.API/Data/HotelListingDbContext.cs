using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System.Globalization;
using System.Text.Json.Nodes;

namespace HotelListing.API.Data
{
    public class HotelListingDbContext : DbContext
    {
        public HotelListingDbContext(DbContextOptions options) : base(options) 
        { 

        }


        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<Country> Countries { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Country>().HasData
            (
                new Country
                {
                    Id = 1,
                    Name = "India",
                    ShortName = "IN"
                },
                new Country
                {
                    Id = 2,
                    Name = "Jamaica",
                    ShortName = "JM"
                },
                new Country
                {
                    Id = 3,
                    Name = "Bahamas",
                    ShortName = "BS" 
                },
                new Country
                {
                    Id = 4,
                    Name = "Cayman Island",
                    ShortName = "CI"
                }
            );

            modelBuilder.Entity<Hotel>().HasData
            (
                new Hotel
                {
                  Id = 1,
                  Name = "Taj",
                  Address = "Chennai",
                  CountryId = 1,
                  Rating = 4.9
                },
                new Hotel
                {
                    Id = 2,
                    Name = "Sandals Resort and Spa",
                    Address = "Negril",
                    CountryId = 2,
                    Rating = 4.5
                },
                new Hotel
                {
                    Id = 3,
                    Name = "Comfort Suites",
                    Address = "George Town",
                    CountryId = 4,
                    Rating = 4.3
                },
                new Hotel
                {
                    Id = 4,
                    Name = "Grand Palldium",
                    Address = "Nassua",
                    CountryId = 3,
                    Rating = 4
                }
            );
        }
    }
}
