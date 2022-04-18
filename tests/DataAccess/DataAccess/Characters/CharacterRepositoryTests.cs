using DataAccess.Characters;
using DataAccess.CrossCutting.Api;
using DataAccess.CrossCutting.Mappers;
using DataAccess.Interfaces.Characters;
using DataAccess.Services.RestServices;
using IoC;
using Moq;
using Xunit;

namespace DataAccess.Tests.Characters
{
    public class CharacterRepositoryTests
    {
        [Fact]
        public void GetAsync_Valid_ReturnsCharacter()
        {
            var restServiceMock = new Mock<IRestService<CharacterDto>>();

            var mapper = AutomapperConfiguration.GetMapper();
            var apiResponseMapper = new ApiResponseMapper(mapper);
            var repository = new CharacterRepository(apiResponseMapper, restServiceMock.Object);

            var character = repository.GetAsync(It.IsAny<int>()).GetAwaiter().GetResult();

            restServiceMock
                .Verify(m => m.GetAsync(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<int>()), Times.Once);
        }

        [Fact]
        public void GetAllAsync_Valid_ReturnsCharacters()
        {
            var restServiceMock = new Mock<IRestService<CharacterDto>>();
            var apiResponseMapperMock = new Mock<IApiResponseMapper>();
            var repository = new CharacterRepository(apiResponseMapperMock.Object, restServiceMock.Object);

            var charactersResponse = repository.GetAllAsync(It.IsAny<int>()).GetAwaiter().GetResult();

            apiResponseMapperMock
                .Verify(m => m.Map(It.IsAny<ApiResponse<CharacterDto>>()), Times.Once);

            restServiceMock
                .Verify(m => m.GetAllAsync(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<int>()), Times.Once);
        }
    }
}
