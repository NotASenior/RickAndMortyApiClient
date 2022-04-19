using Business.Locations;
using DataAccess.Interfaces.Locations;
using IoC;
using Moq;
using Xunit;

namespace Business.Tests.Locations
{
    public class LocationServiceTests
    {
        [Fact]
        public void GetAsync_Valid_ReturnsLocation()
        {
            var mapper = AutomapperConfiguration.GetMapper();
            var repositoryMock = new Mock<ILocationRepository>();
            var service = new LocationService(mapper, repositoryMock.Object);

            var location = service.GetAsync(It.IsAny<int>()).GetAwaiter().GetResult();

            repositoryMock
                .Verify(m => m.GetAsync(It.IsAny<int>()), Times.Once);
        }

        [Fact]
        public void GetAllAsync_Valid_ReturnsLocations()
        {
            var mapper = AutomapperConfiguration.GetMapper();
            var repositoryMock = new Mock<ILocationRepository>();
            var service = new LocationService(mapper, repositoryMock.Object);

            var locationsResponse = service.GetAllAsync(It.IsAny<int>()).GetAwaiter().GetResult();

            repositoryMock
                .Verify(m => m.GetAllAsync(It.IsAny<int>()), Times.Once);
        }
    }
}
