using DataAccess.Interfaces.CrossCutting;
using Entities.Episodes;

namespace DataAccess.Interfaces.Episodes
{
    public interface IEpisodeRepository
    {
        Episode Get(int id);
        Paginated<Episode> GetAll(int page);
    }
}
