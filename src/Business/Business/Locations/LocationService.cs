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

        public async Task<Paginated<Location>> GetAllAsync(int page)
        {
            Paginated<LocationModel>? location = await  repository.GetAllAsync(page);
            Paginated<Location> mappedLocations = mapper.Map<Paginated<Location>>(location);

            return mappedLocations;
        }

        public async Task<Location> GetAsync(int id)
        {
            LocationModel location = await repository.GetAsync(id);
            Location mappedLocation = mapper.Map<Location>(location);

            return mappedLocation;
        }
    }
}
