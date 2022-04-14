using DataAccess.Interfaces.CrossCutting;
using Entities.Episodes;

namespace DataAccess.Interfaces.Episodes
{
    public interface IEpisodeRepository
    {
        Task<Episode> GetAsync(int id);
        Task<Paginated<Episode>> GetAllAsync(int page);
    }
}
