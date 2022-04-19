using Business.Episodes;
using DataAccess.Interfaces.Episodes;
using IoC;
using Moq;
using Xunit;

namespace Business.Tests.Episodes
{
    public class EpisodeServiceTests
    {
        [Fact]
        public void GetAsync_Valid_ReturnsEpisode()
        {
            var mapper = AutomapperConfiguration.GetMapper();
            var repositoryMock = new Mock<IEpisodeRepository>();
            var service = new EpisodeService(mapper, repositoryMock.Object);

            var episode = service.GetAsync(It.IsAny<int>()).GetAwaiter().GetResult();

            repositoryMock
                .Verify(m => m.GetAsync(It.IsAny<int>()), Times.Once);
        }

        [Fact]
        public void GetAllAsync_Valid_ReturnsEpisodes()
        {
            var mapper = AutomapperConfiguration.GetMapper();
            var repositoryMock = new Mock<IEpisodeRepository>();
            var service = new EpisodeService(mapper, repositoryMock.Object);

            var episodesResponse = service.GetAllAsync(It.IsAny<int>()).GetAwaiter().GetResult();

            repositoryMock
                .Verify(m => m.GetAllAsync(It.IsAny<int>()), Times.Once);
        }
    }
}
