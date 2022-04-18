using AutoMapper;
using Business.Interfaces.Episodes;
using DataAccess.Interfaces.CrossCutting;
using DataAccess.Interfaces.Episodes;
using Entities.Episodes;

namespace Business.Episodes
{
    public class EpisodeService : IEpisodeService
    {
        private readonly IMapper mapper;
        private readonly IEpisodeRepository repository;

        public EpisodeService(IMapper mapper, IEpisodeRepository repository)
        {
            this.mapper = mapper;
            this.repository = repository;
        }

        public async Task<Paginated<Episode>> GetAllAsync(int page)
        {
            Paginated<EpisodeDto>? location = await repository.GetAllAsync(page);
            Paginated<Episode> mappedEpisodes = mapper.Map<Paginated<Episode>>(location);

            return mappedEpisodes;
        }

        public async Task<Episode> GetAsync(int id)
        {
            EpisodeDto location = await repository.GetAsync(id);
            Episode mappedEpisode = mapper.Map<Episode>(location);

            return mappedEpisode;
        }
    }
}
