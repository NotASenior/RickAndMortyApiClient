using AutoMapper;
using DataAccess.CrossCutting.Api;
using DataAccess.Interfaces.CrossCutting;
using DataAccess.Interfaces.Locations;
using DataAccess.Services.RestService.Models;
using DataAccess.Services.RestServices;
using DataAccess.Services.RestServices.Static;
using Entities.Locations;

namespace DataAccess.Locations
{
    public class LocationRepository : ILocationRepository
    {
        private readonly string endpoint = ApiUrls.Endpoint;
        private readonly string method = ApiUrls.Location;

        private readonly IMapper mapper;
        private readonly IRestService<LocationModel> restService;

        public LocationRepository(IMapper mapper, IRestService<LocationModel> restService)
        {
            this.mapper = mapper;
            this.restService = restService;
        }

        public async Task<Location> GetAsync(int id)
        {
            LocationModel response = await restService.GetAsync(endpoint, method, id);
            Location entity = mapper.Map<Location>(response);

            return entity;
        }

        public async Task<Paginated<Location>> GetAllAsync(int page)
        {
            ApiResponse<LocationModel>? response = await restService.GetAllAsync(endpoint, method, page);
            Paginated<Location> entities = mapper.Map<Paginated<Location>>(response);

            return entities;
        }
    }
}
