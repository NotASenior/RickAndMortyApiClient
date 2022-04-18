using Entities.Characters;
using DataAccess.Interfaces.CrossCutting;

namespace DataAccess.Interfaces.Characters
{
    public interface ICharacterRepository
    {
        Task<CharacterDto> GetAsync(int id);
        Task<Paginated<CharacterDto>> GetAllAsync(int page);
    }
}
