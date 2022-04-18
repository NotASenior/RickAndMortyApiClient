using DataAccess.Interfaces.CrossCutting;

namespace DataAccess.Interfaces.Episodes
{
    public interface IEpisodeRepository
    {
        Task<EpisodeDto> GetAsync(int id);
        Task<Paginated<EpisodeDto>> GetAllAsync(int page);
    }
}
