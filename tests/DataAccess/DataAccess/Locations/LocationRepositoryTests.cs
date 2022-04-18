using DataAccess.Locations;
using DataAccess.CrossCutting.Api;
using DataAccess.CrossCutting.Mappers;
using DataAccess.Interfaces.Locations;
using DataAccess.Services.RestServices;
using Moq;
using Xunit;
using IoC;

namespace DataAccess.Tests.Locations
{
    public class LocationRepositoryTests
    {
        [Fact]
        public void GetAsync_Valid_ReturnsLocation()
        {
            var restServiceMock = new Mock<IRestService<LocationDto>>();

            var mapper = AutomapperConfiguration.GetMapper();
            var apiResponseMapper = new ApiResponseMapper(mapper);
            var repository = new LocationRepository(apiResponseMapper, restServiceMock.Object);

            var character = repository.GetAsync(It.IsAny<int>()).GetAwaiter().GetResult();

            restServiceMock
                .Verify(m => m.GetAsync(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<int>()), Times.Once);
        }

        [Fact]
        public void GetAllAsync_Valid_ReturnsLocations()
        {
            var restServiceMock = new Mock<IRestService<LocationDto>>();
            var apiResponseMapperMock = new Mock<IApiResponseMapper>();
            var repository = new LocationRepository(apiResponseMapperMock.Object, restServiceMock.Object);

            var charactersResponse = repository.GetAllAsync(It.IsAny<int>()).GetAwaiter().GetResult();

            apiResponseMapperMock
                .Verify(m => m.Map(It.IsAny<ApiResponse<LocationDto>>()), Times.Once);

            restServiceMock
                .Verify(m => m.GetAllAsync(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<int>()), Times.Once);
        }
    }
}
