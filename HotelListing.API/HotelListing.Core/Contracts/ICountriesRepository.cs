using HotelListing.API.Data;
using HotelListing.API.Core.Models.Country;
using System.Threading.Tasks;

namespace HotelListing.API.Core.Contracts
{
    public interface ICountriesRepository : IGenericRepository<Country> 
    {
        Task<Country> GetDetails(int id);
    }
}
