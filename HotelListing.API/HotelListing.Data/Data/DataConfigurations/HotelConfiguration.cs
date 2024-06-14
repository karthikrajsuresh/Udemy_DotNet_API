using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HotelListing.API.Data.Configurations
{
    public class HotelConfiguration : IEntityTypeConfiguration<Hotel>
    {
        public void Configure(EntityTypeBuilder<Hotel> builder)
        {
            builder.HasData
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
                },
                new Hotel
                {
                    Id = 5,
                    Name = "Aman Tokyo",
                    Address = "Chiyoda City",
                    CountryId = 5,
                    Rating = 4.5
                }
            );
        }
    }
}
