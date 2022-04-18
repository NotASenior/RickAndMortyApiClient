using DataAccess.CrossCutting.Api;
using DataAccess.CrossCutting.Mappers;
using DataAccess.Interfaces.CrossCutting;
using DataAccess.Interfaces.Episodes;
using DataAccess.Services.RestServices;
using DataAccess.Services.RestServices.Static;

namespace DataAccess.Episodes
{
    public class EpisodeRepository : IEpisodeRepository
    {
        private readonly string endpoint = ApiUrls.Endpoint;
        private readonly string method = ApiUrls.Episode;

        private readonly IApiResponseMapper mapper;
        private readonly IRestService<EpisodeDto> restService;

        public EpisodeRepository(IApiResponseMapper mapper, IRestService<EpisodeDto> restService)
        {
            this.mapper = mapper;
            this.restService = restService;
        }

        public Task<EpisodeDto> GetAsync(int id)
        {
            return restService.GetAsync(endpoint, method, id);
        }

        public async Task<Paginated<EpisodeDto>> GetAllAsync(int page)
        {
            ApiResponse<EpisodeDto>? response = await restService.GetAllAsync(endpoint, method, page);
            Paginated<EpisodeDto> entities = mapper.Map(response);

            return entities;
        }
    }
}
