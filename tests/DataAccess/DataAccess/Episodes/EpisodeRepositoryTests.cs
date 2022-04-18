using DataAccess.CrossCutting.Api;
using DataAccess.CrossCutting.Mappers;
using DataAccess.Episodes;
using DataAccess.Interfaces.Episodes;
using DataAccess.Services.RestServices;
using IoC;
using Moq;
using Xunit;

namespace DataAccess.Tests.Episodes
{
    public class EpisodeRepositoryTests
    {
        [Fact]
        public void GetAsync_Valid_ReturnsEpisode()
        {
            var restServiceMock = new Mock<IRestService<EpisodeDto>>();

            var mapper = AutomapperConfiguration.GetMapper();
            var apiResponseMapper = new ApiResponseMapper(mapper);
            var repository = new EpisodeRepository(apiResponseMapper, restServiceMock.Object);

            var character = repository.GetAsync(It.IsAny<int>()).GetAwaiter().GetResult();

            restServiceMock
                .Verify(m => m.GetAsync(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<int>()), Times.Once);
        }

        [Fact]
        public void GetAllAsync_Valid_ReturnsEpisodes()
        {
            var restServiceMock = new Mock<IRestService<EpisodeDto>>();
            var apiResponseMapperMock = new Mock<IApiResponseMapper>();
            var repository = new EpisodeRepository(apiResponseMapperMock.Object, restServiceMock.Object);

            var charactersResponse = repository.GetAllAsync(It.IsAny<int>()).GetAwaiter().GetResult();

            apiResponseMapperMock
                .Verify(m => m.Map(It.IsAny<ApiResponse<EpisodeDto>>()), Times.Once);

            restServiceMock
                .Verify(m => m.GetAllAsync(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<int>()), Times.Once);
        }
    }
}
