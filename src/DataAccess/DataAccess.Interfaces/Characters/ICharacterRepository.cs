using Entities.Characters;
using DataAccess.Interfaces.CrossCutting;

namespace DataAccess.Interfaces.Characters
{
    public interface ICharacterRepository
    {
        Task<CharacterModel> GetAsync(int id);
        Task<Paginated<CharacterModel>> GetAllAsync(int page);
    }
}
