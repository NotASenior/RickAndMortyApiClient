using DataAccess.Interfaces.CrossCutting;
using Entities.Locations;

namespace DataAccess.Interfaces.Locations
{
    public interface ILocationRepository
    {
        Task<LocationModel> GetAsync(int id);
        Task<Paginated<LocationModel>> GetAllAsync(int page);
    }
}
