﻿namespace HotelListing.API.Core.Exceptions
{
    public class BadRequestException : ApplicationException
    {
        public BadRequestException(string name, object key) : base($"{name}({key}) Bad Request input value not recognized")
        {

        }
    }
}