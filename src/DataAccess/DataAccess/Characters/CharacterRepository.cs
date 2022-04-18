using DataAccess.CrossCutting.Api;
using DataAccess.CrossCutting.Mappers;
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
        
        private readonly IApiResponseMapper mapper;
        private readonly IRestService<CharacterDto> restService;

        public CharacterRepository(IApiResponseMapper mapper, IRestService<CharacterDto> restService)
        {
            this.mapper = mapper;
            this.restService = restService;
        }

        public Task<CharacterDto> GetAsync(int id)
        {
            return restService.GetAsync(endpoint, method, id);
        }

        public async Task<Paginated<CharacterDto>> GetAllAsync(int page)
        {
            ApiResponse<CharacterDto>? response = await restService.GetAllAsync(endpoint, method, page);
            Paginated<CharacterDto> entities = mapper.Map<CharacterDto>(response);

            return entities;
        }
    }
}
