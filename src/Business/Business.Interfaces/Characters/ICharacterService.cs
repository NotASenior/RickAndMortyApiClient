using DataAccess.Interfaces.CrossCutting;
using Entities.Characters;

namespace Business.Interfaces.Characters
{
    public interface ICharacterService
    {
        Task<Character> GetAsync(int id);
        Task<Paginated<Character>> GetAllAsync(int page);
    }
}
