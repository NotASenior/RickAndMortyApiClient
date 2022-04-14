using AutoMapper;
using DataAccess.CrossCutting.Api;
using DataAccess.Interfaces.CrossCutting;
using DataAccess.Interfaces.Locations;
using DataAccess.Services.RestServices;
using DataAccess.Services.RestServices.Static;

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

        public Task<LocationModel> GetAsync(int id)
        {
            return restService.GetAsync(endpoint, method, id);
        }

        public async Task<Paginated<LocationModel>> GetAllAsync(int page)
        {
            ApiResponse<LocationModel>? response = await restService.GetAllAsync(endpoint, method, page);
            Paginated<LocationModel> entities = mapper.Map<Paginated<LocationModel>>(response);

            return entities;
        }
    }
}
