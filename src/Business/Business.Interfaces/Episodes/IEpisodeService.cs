using DataAccess.Interfaces.CrossCutting;
using Entities.Episodes;

namespace Business.Interfaces.Episodes
{
    public interface IEpisodeService
    {
        Task<Episode> GetAsync(int id);
        Task<Paginated<Episode>> GetAllAsync(int page);
    }
}
