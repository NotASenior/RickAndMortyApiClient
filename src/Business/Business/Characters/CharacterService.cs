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

        public Task<Paginated<Character>> GetAllAsync(int page)
        {
            return repository.GetAllAsync(page);
        }

        public Task<Character> GetAsync(int id)
        {
            return repository.GetAsync(id);
        }
    }
}
