﻿using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HotelListing.API.Data.Configurations
{
    public class CountryConfiguration : IEntityTypeConfiguration<Country>
    {
        public void Configure(EntityTypeBuilder<Country> builder)
        {
            builder.HasData(
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
                },
                new Country
                {
                    Id = 5,
                    Name = "Japan",
                    ShortName = "JP"
                }
            );
        }
    }
}