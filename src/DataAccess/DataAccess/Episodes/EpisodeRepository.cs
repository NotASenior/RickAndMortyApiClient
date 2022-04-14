using AutoMapper;
using DataAccess.CrossCutting.Api;
using DataAccess.Interfaces.CrossCutting;
using DataAccess.Interfaces.Episodes;
using DataAccess.Services.RestService.Models;
using DataAccess.Services.RestServices;
using DataAccess.Services.RestServices.Static;
using Entities.Episodes;

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

        public async Task<Episode> GetAsync(int id)
        {
            EpisodeModel response = await restService.GetAsync(endpoint, method, id);
            Episode entity = mapper.Map<Episode>(response);

            return entity;
        }

        public async Task<Paginated<Episode>> GetAllAsync(int page)
        {
            ApiResponse<EpisodeModel>? response = await restService.GetAllAsync(endpoint, method, page);
            Paginated<Episode> entities = mapper.Map<Paginated<Episode>>(response);

            return entities;
        }
    }
}
