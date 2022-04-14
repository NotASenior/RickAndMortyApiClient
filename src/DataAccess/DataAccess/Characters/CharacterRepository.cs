using AutoMapper;
using DataAccess.CrossCutting.Api;
using DataAccess.Interfaces.Characters;
using DataAccess.Interfaces.CrossCutting;
using DataAccess.Services.RestServices;
using DataAccess.Services.RestServices.Static;

namespace DataAccess.Characters
{
    public class CharacterRepository : ICharacterRepository
    {
        private readonly string endpoint = ApiUrls.Endpoint;
        private readonly string method = ApiUrls.Character;
        
        private readonly IMapper mapper;
        private readonly IRestService<CharacterModel> restService;

        public CharacterRepository(IMapper mapper, IRestService<CharacterModel> restService)
        {
            this.mapper = mapper;
            this.restService = restService;
        }

        public Task<CharacterModel> GetAsync(int id)
        {
            return restService.GetAsync(endpoint, method, id);
        }

        public async Task<Paginated<CharacterModel>> GetAllAsync(int page)
        {
            ApiResponse<CharacterModel>? response = await restService.GetAllAsync(endpoint, method, page);
            Paginated<CharacterModel> entities = mapper.Map<Paginated<CharacterModel>>(response);

            return entities;
        }
    }
}
