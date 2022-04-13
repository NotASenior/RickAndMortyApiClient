using Entities.Characters;
using DataAccess.Interfaces.CrossCutting;

namespace DataAccess.Interfaces.Characters
{
    public interface ICharacterRepository
    {
        Task<Character> GetAsync(int id);
        Task<Paginated<Character>> GetAllAsync(int page);
    }
}
