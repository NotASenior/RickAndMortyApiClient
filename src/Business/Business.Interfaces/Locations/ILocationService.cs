using DataAccess.Interfaces.CrossCutting;
using Entities.Locations;

namespace Business.Interfaces.Locations
{
    public interface ILocationService
    {
        Task<Location> GetAsync(int id);
        Task<Paginated<Location>> GetAllAsync(int page);
    }
}
