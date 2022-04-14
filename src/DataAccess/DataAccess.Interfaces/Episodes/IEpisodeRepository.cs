using DataAccess.Interfaces.CrossCutting;

namespace DataAccess.Interfaces.Episodes
{
    public interface IEpisodeRepository
    {
        Task<EpisodeModel> GetAsync(int id);
        Task<Paginated<EpisodeModel>> GetAllAsync(int page);
    }
}
