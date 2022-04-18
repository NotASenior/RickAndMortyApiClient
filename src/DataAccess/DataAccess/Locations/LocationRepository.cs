using DataAccess.CrossCutting.Api;
using DataAccess.CrossCutting.Mappers;
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

        private readonly IApiResponseMapper mapper;
        private readonly IRestService<LocationDto> restService;

        public LocationRepository(IApiResponseMapper mapper, IRestService<LocationDto> restService)
        {
            this.mapper = mapper;
            this.restService = restService;
        }

        public Task<LocationDto> GetAsync(int id)
        {
            return restService.GetAsync(endpoint, method, id);
        }

        public async Task<Paginated<LocationDto>> GetAllAsync(int page)
        {
            ApiResponse<LocationDto>? response = await restService.GetAllAsync(endpoint, method, page);
            Paginated<LocationDto> entities = mapper.Map<LocationDto>(response);

            return entities;
        }
    }
}
