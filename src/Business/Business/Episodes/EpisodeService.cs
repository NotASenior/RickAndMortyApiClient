using AutoMapper;
using Business.Interfaces.Episodes;
using DataAccess.Interfaces.CrossCutting;
using DataAccess.Interfaces.Episodes;
using Entities.Episodes;

namespace Business.Episodes
{
    internal class EpisodeService : IEpisodeService
    {
        private readonly IMapper mapper;
        private readonly IEpisodeRepository repository;

        public EpisodeService(IMapper mapper, IEpisodeRepository repository)
        {
            this.mapper = mapper;
            this.repository = repository;
        }

        public Task<Paginated<Episode>> GetAllAsync(int page)
        {
            return repository.GetAllAsync(page);
        }

        public Task<Episode> GetAsync(int id)
        {
            return repository.GetAsync(id);
        }
    }
}
