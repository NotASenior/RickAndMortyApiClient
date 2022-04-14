using AutoMapper;
using Business.Interfaces.Locations;
using DataAccess.Interfaces.CrossCutting;
using DataAccess.Interfaces.Locations;
using Entities.Locations;

namespace Business.Locations
{
    public class LocationService : ILocationService
    {
        private readonly IMapper mapper;
        private readonly ILocationRepository repository;

        public LocationService(IMapper mapper, ILocationRepository repository)
        {
            this.mapper = mapper;
            this.repository = repository;
        }

        public Task<Paginated<Location>> GetAllAsync(int page)
        {
            return repository.GetAllAsync(page);
        }

        public Task<Location> GetAsync(int id)
        {
            return repository.GetAsync(id);
        }
    }
}
