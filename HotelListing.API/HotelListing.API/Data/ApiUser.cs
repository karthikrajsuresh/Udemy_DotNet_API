﻿using Microsoft.AspNetCore.Identity;

namespace HotelListing.API.Data
{
    public class ApiUser : IdentityUser
    {
        public String FirstName { get; set; }
        public String LastName { get; set; }
    }
}
