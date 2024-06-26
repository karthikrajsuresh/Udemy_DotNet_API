﻿using AutoMapper;
using HotelListing.API.Core.Contracts;
using HotelListing.API.Data;
using HotelListing.API.Core.Repository;

namespace HotelListing.API.Core.Repository
{
    public class HotelsRepository : GenericRepository<Hotel>, IHotelsRepository
    {
        public HotelsRepository(HotelListingDbContext context, IMapper mapper) : base(context, mapper)
        {
        }
    }
}
