using DataAccess.Interfaces.CrossCutting;
using Entities.Locations;

namespace DataAccess.Interfaces.Locations
{
    public interface ILocationRepository
    {
        Task<Location> GetAsync(int id);
        Task<Paginated<Location>> GetAllAsync(int page);
    }
}
