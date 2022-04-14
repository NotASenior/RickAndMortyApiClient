using AutoMapper;
using DataAccess.CrossCutting.Api;
using DataAccess.Interfaces.Characters;
using DataAccess.Interfaces.CrossCutting;
using DataAccess.Services.RestService.Models;
using DataAccess.Services.RestServices;
using DataAccess.Services.RestServices.Static;
using Entities.Characters;

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

        public async Task<Character> GetAsync(int id)
        {
            CharacterModel response = await restService.GetAsync(endpoint, method, id);
            Character entity = mapper.Map<Character>(response);

            return entity;
        }

        public async Task<Paginated<Character>> GetAllAsync(int page)
        {
            ApiResponse<CharacterModel>? response = await restService.GetAllAsync(endpoint, method, page);
            Paginated<Character> entities = mapper.Map<Paginated<Character>>(response);

            return entities;
        }
    }
}
