using DataAccess.Interfaces.CrossCutting;
using Entities.Locations;

namespace DataAccess.Interfaces.Locations
{
    public interface ILocationRepository
    {
        Location Get(int id);
        Paginated<Location> GetAll(int page);
    }
}
