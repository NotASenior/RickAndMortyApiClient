using AutoMapper;
using DataAccess.CrossCutting.Api;
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

        private readonly IMapper mapper;
        private readonly IRestService<EpisodeModel> restService;

        public EpisodeRepository(IMapper mapper, IRestService<EpisodeModel> restService)
        {
            this.mapper = mapper;
            this.restService = restService;
        }

        public Task<EpisodeModel> GetAsync(int id)
        {
            return restService.GetAsync(endpoint, method, id);
        }

        public async Task<Paginated<EpisodeModel>> GetAllAsync(int page)
        {
            ApiResponse<EpisodeModel>? response = await restService.GetAllAsync(endpoint, method, page);
            Paginated<EpisodeModel> entities = mapper.Map<Paginated<EpisodeModel>>(response);

            return entities;
        }
    }
}
