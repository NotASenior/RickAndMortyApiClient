using AutoMapper;
using Business.Interfaces.Characters;
using DataAccess.Interfaces.Characters;
using DataAccess.Interfaces.CrossCutting;
using Entities.Characters;

namespace Business.Characters
{
    public class CharacterService : ICharacterService
    {
        private readonly IMapper mapper;
        private readonly ICharacterRepository repository;

        public CharacterService(IMapper mapper, ICharacterRepository repository)
        {
            this.mapper = mapper;
            this.repository = repository;
        }

        public async Task<Paginated<Character>> GetAllAsync(int page)
        {
            Paginated<CharacterDto>? location = await repository.GetAllAsync(page);
            Paginated<Character> mappedCharacters = mapper.Map<Paginated<Character>>(location);

            return mappedCharacters;
        }

        public async Task<Character> GetAsync(int id)
        {
            CharacterDto location = await repository.GetAsync(id);
            Character mappedCharacter = mapper.Map<Character>(location);

            return mappedCharacter;
        }
    }
}
