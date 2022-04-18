using DataAccess.Interfaces.CrossCutting;
using Entities.Locations;

namespace DataAccess.Interfaces.Locations
{
    public interface ILocationRepository
    {
        Task<LocationDto> GetAsync(int id);
        Task<Paginated<LocationDto>> GetAllAsync(int page);
    }
}
